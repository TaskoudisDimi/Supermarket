using Microsoft.Data.SqlClient;
using System.Data;

namespace SupermarketWeb.Data;

public class DataContext
{
    private static readonly object _lock = new();
    private static DataContext? _instance;
    public static int QueryTimeOut = 30;
    public static string ConnectionString = "";

    public SqlConnection? Connection { get; private set; }
    public SqlDataReader? Reader { get; private set; }

    private DataContext() { }

    public static DataContext Instance
    {
        get
        {
            lock (_lock)
            {
                _instance ??= new DataContext();
                return _instance;
            }
        }
    }

    public static void Configure(string connectionString)
    {
        ConnectionString = connectionString;
        _instance = null; // reset on reconfigure
    }

    public bool CheckConnection()
    {
        CloseReader();
        if (Connection == null || Connection.State != ConnectionState.Open)
            return OpenConnection();
        return true;
    }

    private void CloseReader()
    {
        try
        {
            Reader?.Close();
            Reader?.Dispose();
            Reader = null;
        }
        catch { }
    }

    public bool OpenConnection()
    {
        CloseReader();
        try
        {
            Connection?.Dispose();
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            return true;
        }
        catch (Exception ex)
        {
            Utils.Log($"DB connection failed: {ex.Message}");
            Connection?.Dispose();
            Connection = null;
            SqlConnection.ClearAllPools();
            return false;
        }
    }

    public DataTable? SelectDataTable(string sql, List<SqlParameter>? parameters = null)
    {
        if (!CheckConnection()) return null;
        var dt = new DataTable();
        try
        {
            using var cmd = BuildCommand(sql, parameters);
            Reader = cmd.ExecuteReader();
            dt.Load(Reader);
            CloseReader();
        }
        catch (Exception ex)
        {
            Utils.Log($"SelectDataTable error: {ex.Message}");
            CloseReader();
        }
        return dt;
    }

    public object? ExecScalar(string sql, List<SqlParameter>? parameters = null)
    {
        if (!CheckConnection()) return null;
        try
        {
            using var cmd = BuildCommand(sql, parameters);
            return cmd.ExecuteScalar();
        }
        catch (Exception ex)
        {
            Utils.Log($"ExecScalar error: {ex.Message}");
            return null;
        }
    }

    public int ExecuteNQ(string sql, List<SqlParameter>? parameters = null)
    {
        if (!CheckConnection()) return 0;
        try
        {
            using var cmd = BuildCommand(sql, parameters);
            return cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Utils.Log($"ExecuteNQ error: {ex.Message}");
            return 0;
        }
    }

    public int ExecuteStoredProcedure(string procedureName, List<SqlParameter>? parameters = null)
    {
        if (!CheckConnection()) return -1;
        try
        {
            using var cmd = new SqlCommand(procedureName, Connection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = QueryTimeOut
            };
            if (parameters?.Count > 0)
                cmd.Parameters.AddRange(parameters.ToArray());
            return cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Utils.Log($"StoredProcedure error ({procedureName}): {ex.Message}");
            return -1;
        }
    }

    private SqlCommand BuildCommand(string sql, List<SqlParameter>? parameters)
    {
        var cmd = new SqlCommand(sql, Connection)
        {
            CommandTimeout = QueryTimeOut,
            CommandType = CommandType.Text
        };
        if (parameters?.Count > 0)
            cmd.Parameters.AddRange(parameters.ToArray());
        return cmd;
    }
}
