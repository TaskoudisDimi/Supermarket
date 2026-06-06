using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Text;

namespace SupermarketWeb.Data;

public static class DataModel
{
    public static List<T> Select<T>(
        string[]? fields = null,
        string where = "",
        List<SqlParameter>? queryparams = null,
        string? table = null,
        string? sort = null,
        int pageIndex = -1,
        int pageSize = -1,
        int top = -1) where T : class, new()
    {
        string tableName = ResolveTable<T>(table);
        var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var selectFields = props
            .Where(p => fields == null || fields.Contains(p.Name, StringComparer.OrdinalIgnoreCase))
            .Select(p => $"[{p.Name}]");

        string topClause = (top > -1 && pageIndex == -1) ? $"TOP ({top})" : "";
        string whereClause = !string.IsNullOrEmpty(where) ? $"WHERE ({where})" : "";
        string orderClause = BuildOrder(sort, pageIndex, pageSize);
        string sql = $"SELECT {topClause} {string.Join(",", selectFields)} FROM {tableName} {whereClause} {orderClause}";

        var dt = DataContext.Instance.SelectDataTable(sql, queryparams);
        return dt is null ? [] : MapDataTable<T>(dt);
    }

    public static int? Create<T>(this T item, List<SqlParameter>? queryparams = null, string? table = null) where T : class, new()
    {
        string tableName = ResolveTable<T>(table);
        var props = typeof(T).GetProperties();
        var fields = new List<string>();
        var values = new List<string>();
        var parameters = new List<SqlParameter>();

        int paramIdx = 0;
        foreach (var p in props)
        {
            if (p.GetCustomAttribute<PrimaryKeyAttribute>() != null) continue;
            if (p.GetCustomAttribute<ImageAttribute>() != null)
            {
                var imgVal = p.GetValue(item);
                if (imgVal is byte[] bytes)
                {
                    string paramName = $"@img{paramIdx++}";
                    fields.Add($"[{p.Name}]");
                    values.Add(paramName);
                    parameters.Add(new SqlParameter(paramName, SqlDbType.VarBinary) { Value = bytes });
                }
                continue;
            }

            object? val = p.GetValue(item);
            bool encrypted = p.GetCustomAttribute<EncryptedAttribute>() != null;
            string sqlVal = GetSqlValue(p, val, encrypted);

            fields.Add($"[{p.Name}]");
            values.Add(sqlVal);
        }

        if (queryparams?.Count > 0) parameters.AddRange(queryparams);

        string sql = $"INSERT INTO [{tableName}] ({string.Join(",", fields)}) VALUES ({string.Join(",", values)})";
        int result = DataContext.Instance.ExecuteNQ(sql, parameters.Count > 0 ? parameters : null);
        return result > 0 ? 1 : -1;
    }

    public static int? Update<T>(this T item, string[]? updateOnly = null) where T : class, new()
    {
        string tableName = ResolveTable<T>(null);
        var props = typeof(T).GetProperties();
        string? pkName = null;
        object? pkValue = null;
        var sb = new StringBuilder($"UPDATE [{tableName}] SET ");
        var setClauses = new List<string>();

        foreach (var p in props)
        {
            if (p.GetCustomAttribute<PrimaryKeyAttribute>() != null)
            {
                pkName = p.Name;
                pkValue = p.GetValue(item);
                continue;
            }
            if (updateOnly != null && !updateOnly.Contains(p.Name, StringComparer.OrdinalIgnoreCase)) continue;
            if (p.GetCustomAttribute<ImageAttribute>() != null) continue;

            object? val = p.GetValue(item);
            bool encrypted = p.GetCustomAttribute<EncryptedAttribute>() != null;
            string sqlVal = GetSqlValue(p, val, encrypted);
            setClauses.Add($"[{p.Name}] = {sqlVal}");
        }

        if (pkName is null || setClauses.Count == 0) return -1;
        string sql = $"UPDATE [{tableName}] SET {string.Join(", ", setClauses)} WHERE [{pkName}] = {pkValue}";
        int result = DataContext.Instance.ExecuteNQ(sql);
        return result > 0 ? 1 : -1;
    }

    public static int? Delete<T>(this T item) where T : class, new()
    {
        string tableName = ResolveTable<T>(null);
        var props = typeof(T).GetProperties();
        string? pkName = null;
        object? pkValue = null;

        foreach (var p in props)
        {
            if (p.GetCustomAttribute<PrimaryKeyAttribute>() != null)
            {
                pkName = p.Name;
                pkValue = p.GetValue(item);
                break;
            }
        }

        if (pkName is null) return -1;
        string sql = $"DELETE FROM [{tableName}] WHERE [{pkName}] = {pkValue}";
        int result = DataContext.Instance.ExecuteNQ(sql);
        return result > 0 ? 1 : -1;
    }

    public static bool CleanDB()
    {
        try
        {
            int res = DataContext.Instance.ExecuteStoredProcedure("SP_CleanDatabaseTables");
            return res >= 0;
        }
        catch { return false; }
    }

    public static void Backup(string path)
    {
        string sql = $"BACKUP DATABASE smarket TO DISK = '{path}' WITH FORMAT, MEDIANAME = 'SQLBackups', NAME = 'Full Backup';";
        DataContext.Instance.ExecuteNQ(sql);
    }

    public static void RestoreDB(string pathDB)
    {
        string sql = $"RESTORE DATABASE smarket FROM DISK = '{pathDB}' WITH REPLACE, RECOVERY";
        DataContext.Instance.ExecuteNQ(sql);
    }

    // ── helpers ──────────────────────────────────────────────────────────────

    private static string ResolveTable<T>(string? table)
    {
        if (!string.IsNullOrEmpty(table)) return table!;
        var attr = typeof(T).GetCustomAttribute<TableNameAttribute>();
        return attr?.TableName ?? typeof(T).Name;
    }

    private static string BuildOrder(string? sort, int pageIndex, int pageSize)
    {
        if (string.IsNullOrEmpty(sort)) return "";
        if (pageIndex > -1 && pageSize > -1)
            return $"ORDER BY {sort} OFFSET (({pageIndex} - 1) * {pageSize}) ROWS FETCH NEXT {pageSize} ROWS ONLY";
        return $"ORDER BY {sort}";
    }

    private static string GetSqlValue(PropertyInfo prop, object? val, bool encrypted)
    {
        if (encrypted && val is not null)
        {
            string hash = Utils.HashPassword(val.ToString()!);
            return $"'{hash.Replace("'", "''")}'";
        }

        if (val is null) return "NULL";

        Type t = prop.PropertyType;
        if (t == typeof(DateTime) || t == typeof(DateTime?))
            return $"'{((DateTime)val):yyyy-MM-dd HH:mm:ss}'";
        if (t == typeof(bool) || t == typeof(bool?))
            return ((bool)val) ? "1" : "0";
        if (t == typeof(string))
            return $"'{val.ToString()!.Replace("'", "''")}'";
        if (t == typeof(int) || t == typeof(int?) || t == typeof(long) || t == typeof(long?))
            return val.ToString()!;
        if (t == typeof(decimal) || t == typeof(decimal?) || t == typeof(float) || t == typeof(double))
            return val.ToString()!.Replace(",", ".");

        return $"'{val}'";
    }

    public static List<T> MapDataTable<T>(DataTable table) where T : class, new()
    {
        var list = new List<T>();
        var props = typeof(T).GetProperties();
        foreach (DataRow row in table.Rows)
        {
            var obj = new T();
            foreach (var prop in props)
            {
                if (!table.Columns.Contains(prop.Name)) continue;
                object val = row[prop.Name];
                if (val == DBNull.Value || val is null)
                {
                    if (prop.PropertyType == typeof(string))
                        prop.SetValue(obj, string.Empty);
                    continue;
                }
                try
                {
                    Type target = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(val, target));
                }
                catch { }
            }
            list.Add(obj);
        }
        return list;
    }
}
