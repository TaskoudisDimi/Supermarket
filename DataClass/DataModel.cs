using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SupermarketTuto.Utils;
using Newtonsoft.Json;

namespace ClassLibrary1
{
    public static class DataModel
    {

        private static Dictionary<string, DataTable> cachedTables = new Dictionary<string, DataTable>();
        public static T[] Select<T>(string[] fields = null, string where = "", List<SqlParameter> queryparams = null, string table = null, string sort = null, int pageIndex = -1, int pageSize = -1, int top = -1) where T : class, new()
        {
            string error = "";
            return Select<T>(ref error, fields, where, queryparams, table, sort, pageIndex, pageSize, top);
        }


        public static T[] Select<T>(ref string error, string[] fields = null, string where = "", List<SqlParameter> queryparams = null, string table = null, string sort = null, int pageIndex = -1, int pageSize = -1, int top = -1) where T : class, new()
        {
            string tableName = table;
            if (String.IsNullOrEmpty(table))
            {
                TableNameAttribute tableAttribute = (TableNameAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableNameAttribute));

                if (tableAttribute == null)
                {
                    error = "Class doesn't have TableNameAttribute";
                    return null;
                }
                tableName = tableAttribute.TableName;
            }

            error = "";
            try
            {
                //string cacheKey = $"{tableName}_{where}_{sort}_{pageIndex}_{pageSize}_{top}";
                //if (cachedTables.TryGetValue(cacheKey, out DataTable cachedTable))
                //{
                //    // If the cached DataTable exists, use it directly.
                //    List<T> dataList = GetListFromDataTable<T>(cachedTable);
                //    return dataList.ToArray();
                //}

                PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                List<string> selectFields = new List<string>();
                List<SqlParameter> para = new List<SqlParameter>();
                if (queryparams != null && queryparams.Count > 0)
                {
                    para.AddRange(queryparams);
                }
                foreach (PropertyInfo p in properties)
                {
                    string fieldName = p.Name;
                    string memberName = p.Name;
                    if (Attribute.IsDefined(p, typeof(JsonPropertyAttribute)))
                    {
                        JsonPropertyAttribute attr = p.GetCustomAttribute<JsonPropertyAttribute>();
                        fieldName = attr.PropertyName;
                    }

                    if (Attribute.IsDefined(p, typeof(CalculatedFieldAttribute)))
                    {
                        continue;
                    }

                    if (fields == null || ContainsNoCase(fields, memberName))
                    {
                        selectFields.Add($"[{fieldName}]");
                    }
                }

                string order = "";
                if (!string.IsNullOrEmpty(sort))
                {
                    if (pageIndex > -1 && pageSize > -1)
                    {
                        order = $" ORDER BY {sort} offset (({pageIndex} - 1) * {pageSize}) rows fetch next {pageSize} rows only";
                    }
                    else
                        order = $" ORDER BY {sort}";
                }

                string topSelect = (top > -1 && pageIndex == -1 && pageSize == -1) ? $"TOP ({top})" : "";
                string whereSelect = (!String.IsNullOrEmpty(where)) ? $"WHERE ({where})" : "";
                string sql = $"SELECT {topSelect} {string.Join(",", selectFields)} FROM {tableName} {whereSelect} {order}";

                DataTable dt = DataContext.Instance.SelectDataTable(sql, para);

                List<T> result = GetListFromDataTable<T>(dt);

                T[] res = null;
                if (dt != null)
                {
                    res = Deserlize<T>(dt);
                    dt.Dispose();
                }

                //// Cache the DataTable for future use.
                //cachedTables[cacheKey] = dt;

                return res;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }


        public static int? Create<T>(this T item, string[] fields = null, List<SqlParameter> queryparams = null, string table = null, string error = null) where T : class, new()
        {
            string tableName = table;
            if (String.IsNullOrEmpty(table))
            {
                TableNameAttribute tableAttribute = (TableNameAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableNameAttribute));
                if (tableAttribute == null)
                {
                    error = "Class doesn't exist";
                    return null;
                }
                tableName = tableAttribute.TableName;
            }

            try
            {
                PropertyInfo[] properties = typeof(T).GetProperties();
                List<string> selectFields = new List<string>();
                List<SqlParameter> para = new List<SqlParameter>();
                string fieldName = "";
                List<object> values = new List<object>();

                if (queryparams != null && queryparams.Count > 0)
                {
                    para.AddRange(queryparams);
                }
                foreach (PropertyInfo p in properties)
                {
                    if (p.Name.ToLower().Contains("prodid")) continue;
                    selectFields.Add(p.Name);
                }
                foreach (PropertyInfo prop in properties)
                {
                    if (prop.Name.ToLower().Contains("prodid")) continue;
                    object Value = prop.GetValue(item, null);
                    object ValuesCMD = GetValueFromItem(prop, Value);
                    values.Add(ValuesCMD);
                }

                string cmd = $@"SET ANSI_WARNINGS OFF;
                                Insert Into [{tableName}] ({string.Join(",", selectFields)})
                                VALUES ({string.Join(",", values)})
                                SET ANSI_WARNINGS ON;";

                int result = DataContext.Instance.ExecuteNQ(cmd);

                if (result > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        public static int? Update<T>(this T item, string[] updateOnly = null, string error = "") where T : class, new()
        {

            StringBuilder sb = new StringBuilder();
            string table = "";
            TableNameAttribute tableName = (TableNameAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableNameAttribute));
            if (tableName == null)
            {
                error = "This class doesn't exist";
                return null;
            }
            table = tableName.TableName;
            try
            {
                PropertyInfo[] properties = typeof(T).GetProperties();
                object idOfTable = null;
                object valueOfIdOfTable = null;
                bool findPrimaryKey = false;
                List<object> values = new List<object>();
                sb.Append($"Update {table} set ");
                foreach (PropertyInfo prop in properties)
                {
                    if (prop.Name.ToLower().Contains("id") && !findPrimaryKey)
                    {
                        idOfTable = prop.Name;
                        valueOfIdOfTable = prop.GetValue(item, null);
                        findPrimaryKey = true;
                        continue;
                    }
                    object Value = prop.GetValue(item, null);
                    object ValuesCMD = GetValueFromItem(prop, Value);
                    values.Add(ValuesCMD);
                    sb.Append($"[{table}].[{prop.Name}] = {ValuesCMD} ,");
                }
                string cmd = sb.ToString();
                cmd = cmd.TrimEnd(' ', ',');
                cmd = cmd + $" where {idOfTable} = {valueOfIdOfTable}";
                int result = DataContext.Instance.ExecuteNQ(cmd);
                if (result > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }

            }
            catch
            {
                return -1;
            }
        }

        public static int? Delete<T>(this T item, string error = "") where T : class, new()
        {
            StringBuilder sb = new StringBuilder();
            string table = "";
            TableNameAttribute tableName = (TableNameAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableNameAttribute));
            if (tableName == null)
            {
                error = "This class doesn't exist";
                return null;
            }
            table = tableName.TableName;
            try
            {
                PropertyInfo[] properties = typeof(T).GetProperties();
                object idOfTable = null;
                object valueOfIdOfTable = null;
                bool findPrimaryKey = false;
                List<object> values = new List<object>();
                sb.Append($"Delete From {table}");
                foreach (PropertyInfo prop in properties)
                {
                    if (prop.Name.ToLower().Contains("id") && !findPrimaryKey)
                    {
                        idOfTable = prop.Name;
                        valueOfIdOfTable = prop.GetValue(item, null);
                        findPrimaryKey = true;
                        continue;
                    }
                }
                sb.Append($" where {idOfTable} = {valueOfIdOfTable}");
                string cmd = sb.ToString();
                int result = DataContext.Instance.ExecuteNQ(cmd);
                if (result > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }



        #region Helpers

        private static object GetValueFromItem(PropertyInfo prop, object val)
        {
            if (prop.PropertyType == typeof(DateTime))
            {
                return string.Format("'{0}'", Utils.GetDate(val, new DateTime(1700, 1, 1)).ToString("yyyy-MM-dd H:mm:ss"));
            }
            else if (prop.PropertyType == typeof(DateTime?))
            {
                return string.Format("'{0}'", Utils.GetDate(val).Value.ToString("yyyy-MM-dd H:mm:ss"));
            }
            else if (prop.PropertyType == typeof(int))
            {
                int result = Utils.GetInt(val);
                return result.ToString();
            }
            else if (prop.PropertyType == typeof(int?))
            {
                int result = Utils.GetInt(val);
                return result.ToString();
            }
            else if (prop.PropertyType == typeof(float))
            {
                return Utils.GetString(Utils.GetFloat(val)).Replace(",", ".");
            }
            else if (prop.PropertyType == typeof(float?))
            {
                float? result = Utils.GetNullFloat(val);
                return result == null ? null : Utils.GetString(result).Replace(",", ".");
            }
            else if (prop.PropertyType == typeof(double))
            {
                return Utils.GetString(Utils.GetDouble(val)).Replace(",", ".");
            }
            else if (prop.PropertyType == typeof(double?))
            {
                double? result = Utils.GetNullDouble(val);
                return result == null ? null : Utils.GetString(result).Replace(",", ".");
            }
            else if (prop.PropertyType == typeof(decimal))
            {
                decimal val1 = Utils.GetDecimal(val);
                string strVal = Utils.GetString(val1);
                return strVal.Replace(",", ".");
            }
            else if (prop.PropertyType == typeof(decimal?))
            {
                decimal? result = Utils.GetNullDecimal(val);
                return result == null ? null : Utils.GetString(result).Replace(",", ".");
            }
            else if (prop.PropertyType == typeof(long))
            {
                return Utils.GetInt(val);
            }
            else if (prop.PropertyType == typeof(long?))
            {
                long result = Utils.GetInt(val);
                return result.ToString();
            }
            else if (prop.PropertyType == typeof(bool) || prop.PropertyType == typeof(bool?))
            {
                return Utils.GetBool(val) ? "1" : "0";
            }
            else if (prop.PropertyType == typeof(string))
            {
                return string.Format("'{0}'", Utils.GetString(val));
            }

            //string strValue = $"ENCRYPTBYPASSPHRASE('{Globals.EncryptionKey}', {strValue})";

            return null;
        }

        public static bool ContainsNoCase(string[] fields, string value)
        {
            if (fields == null)
                return false;
            string v = value.Trim().ToLower();
            foreach (string s in fields)
            {
                if (s.ToLower().CompareTo(v) == 0)
                    return true;
            }
            return false;
        }

        public static T[] Deserlize<T>(DataTable dt) where T : new()
        {
            if (dt == null)
                return null;
            if (dt.Rows.Count == 0)
            {
                return new T[0];
            }

            List<T> resList = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                resList.Add(Deserlize<T>(dr));
            }

            return resList.ToArray();
        }

        public static T Deserlize<T>(DataRow dr) where T : new()
        {
            if (dr == null)
                return default(T);

            List<T> resList = new List<T>();
            T t = new T();
            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (DataColumn dc in dr.Table.Columns)
            {
                // PropertyInfo propInfo = typeof(T).GetProperty(dc.ColumnName,
                //     BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                PropertyInfo propInfo = null;
                foreach (PropertyInfo p in properties)
                {
                    if (Attribute.IsDefined(p, typeof(JsonPropertyAttribute)))
                    {
                        JsonPropertyAttribute attr = p.GetCustomAttribute<JsonPropertyAttribute>();
                        if (attr != null)
                        {
                            if (String.Equals(dc.ColumnName, attr.PropertyName, StringComparison.OrdinalIgnoreCase))
                            {
                                propInfo = p;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (String.Equals(dc.ColumnName, p.Name, StringComparison.OrdinalIgnoreCase))
                        {
                            propInfo = p;
                            break;
                        }
                    }
                }

                if (propInfo != null && propInfo.CanWrite)
                {
                    object objVal = null;
                    if (!dr.IsNull(dc.ColumnName))
                    {
                        var tp = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;
                        //if (!Attribute.IsDefined(propInfo, typeof(BinaryFieldAttribute)))
                        {
                            objVal = Convert.ChangeType(dr[dc], tp);
                        }
                        //else
                        //{
                        //    objVal = Base64.Base64Encode((byte[])dr[dc]);
                        //}
                    }
                    propInfo.SetValue(t, objVal, null);
                }
            }
            return t;
        }


        public static List<T> GetListFromDataTable<T>(DataTable table) where T : class, new()
        {
            List<T> list = new List<T>();
            if (table != null)
            {
                foreach (var row in table.AsEnumerable())
                {
                    list.Add(GetObjectFromDataRow<T>(row));
                }
                table.Dispose();
            }
            return list;
        }

        public static T GetObjectFromDataRow<T>(DataRow row) where T : class, new()
        {

            T obj = new T();
            foreach (var prop in obj.GetType().GetProperties())
            {
                PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                Type propType = propertyInfo.PropertyType;

                // If there is no setter for this property
                if (propertyInfo.SetMethod == null)
                    continue;

                string ColumnName = prop.Name;

                if (row.Table.Columns.Contains(ColumnName))
                {
                    object value = row[ColumnName];

                    if (value == null || value == DBNull.Value)
                    {
                        if (propertyInfo.PropertyType == typeof(string))
                            propertyInfo.SetValue(obj, string.Empty, null);
                        else
                            propertyInfo.SetValue(obj, null, null);
                    }
                    else
                    {
                        // If it is nullable
                        if (propType.IsGenericType && propType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                        {
                            if (propType == typeof(int?))
                            {
                                value = Utils.GetNullInt(value);
                                propertyInfo.SetValue(obj, ChangeType<int>(value), null);
                            }
                            else if (propType == typeof(long?))
                            {
                                value = Utils.GetNullLong(value);
                                propertyInfo.SetValue(obj, ChangeType<long>(value), null);
                            }
                            else if (propType == typeof(decimal?))
                            {
                                value = Utils.GetNullDecimal(value);
                                propertyInfo.SetValue(obj, ChangeType<decimal>(value), null);
                            }
                            else if (propType == typeof(float?))
                            {
                                value = Utils.GetNullFloat(value);
                                propertyInfo.SetValue(obj, ChangeType<float>(value), null);
                            }
                            else if (propType == typeof(double?))
                            {
                                value = Utils.GetNullDouble(value);
                                propertyInfo.SetValue(obj, ChangeType<double>(value), null);
                            }
                            else if (propType == typeof(bool?))
                            {
                                value = Utils.GetNullBool(value);
                                propertyInfo.SetValue(obj, ChangeType<bool>(value), null);
                            }
                            else if (propType == typeof(DateTime?))
                            {
                                //TODO propType = typeof(DateTime); DateTime temp; if (DateTime.TryParse(Utils.GetString(value), out temp)) { value = temp; } else { value = new DateTime(1900, 1, 1); }
                                propertyInfo.SetValue(obj, ChangeType<DateTime>(value), null);
                            }
                        }
                        else// If the type is not nullable
                        {
                            if (propType == typeof(int)) { value = Utils.GetInt(value, 0); }
                            else if (propType == typeof(long)) { value = Utils.GetLong(value, 0); }
                            else if (propType == typeof(float)) { value = Utils.GetFloat(value, 0); }
                            else if (propType == typeof(double)) { value = Utils.GetDouble(value, 0); }
                            else if (propType == typeof(decimal)) { value = Utils.GetDecimal(value, 0); }
                            else if (propType == typeof(bool)) { value = Utils.GetBool(value, false); }
                            else if (propType == typeof(DateTime)) { value = Utils.GetDate(value, new DateTime(1700, 1, 1)); }
                            else if (propType == typeof(byte)) {
                                string stringValue = Convert.ToBase64String((byte[])value);
                                propertyInfo.SetValue(obj, stringValue, null);
                            }

                            propertyInfo.SetValue(obj, Convert.ChangeType(value, propType), null);
                        }
                    }
                }
            }
            return obj;
        }

        public static T ChangeType<T>(object value)
        {
            var t = typeof(T);

            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return default(T);
                }

                t = Nullable.GetUnderlyingType(t);
            }

            return (T)Convert.ChangeType(value, t);
        }


        #endregion
    }

    public class CalculatedFieldAttribute : Attribute
    {

    }
}
