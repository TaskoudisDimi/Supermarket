using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using System.Data.Common;
using SupermarketTuto.Utils;

namespace ClassLibrary1
{
    public class DataContext
    {

        private static DataContext instance = null;
        private static readonly object padlock = new object();
        public static int queryTimeOut = 20;
        static Dictionary<int, DataContext> instances = new Dictionary<int, DataContext>();
        private static readonly ThreadLocal<int> currentInstanceId = new ThreadLocal<int>();
        public static string connectionString;
        public SqlDataReader reader = null;
        public SqlConnection connection = null;

        public DataContext()
        {
            connectionString = ConfigurationManager.ConnectionStrings["smarketdb"].ConnectionString;
        }

        public static DataContext Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataContext();
                    }
                    return instance;
                }
            }
        }

        public bool CheckConnection()
        {
            try
            {
                CloseConnection();
            }
            catch (Exception ex)
            {

            }
            if (connection == null || connection.State != ConnectionState.Open)
            {
                return openConnection();
            }
            return true;
        }

        private void CloseConnection(bool OK = true)
        {
            try
            {
                if (connection == null)
                    return;
                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                    reader = null;
                }
            }
            catch (Exception ex)
            {

            }

        }

        public bool openConnection()
        {
            CloseConnection();
            connection = new SqlConnection(connectionString);
            try
            {
                using (Locker.Lock(instances))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {

                connection.Dispose();
                connection = null;
                instances.Remove(currentInstanceId.Value);
                SqlConnection.ClearAllPools();
            }
            return connection != null;
        }

        public SqlDataReader SelectDataReader(string sql, List<SqlParameter> parameters = null)
        {
            try
            {
                if (!CheckConnection())
                {
                    return null;
                }
                using (Locker.Lock(instances))
                {
                    DateTime dtStart = DateTime.Now;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandTimeout = queryTimeOut;
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    if (parameters != null && parameters.Count > 0)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }
                    try
                    {
                        reader = cmd.ExecuteReader();
                        instances.Remove(currentInstanceId.Value);
                    }
                    catch
                    {

                    }
                    long dt = (long)((DateTime.Now - dtStart).TotalMilliseconds);
                    if (dt > 100)
                    {

                    }
                }
            }
            catch
            {
                reader = null;
            }
            
            return reader;
        }

        public DataTable SelectDataTable(string sql, List<SqlParameter> parameters = null)
        {
            DataTable dt = new DataTable();
            DateTime dtStart = DateTime.Now;
            if (!CheckConnection())
            {
                return null;
            }
            using (Locker.Lock(instances))
            {
                try
                {
                    if(parameters != null && parameters.Count > 0)
                    {
                        reader = SelectDataReader(sql, parameters);
                        
                    }
                    else
                    {
                        reader = SelectDataReader(sql);
                    }
                    dt.Load(reader);
                }
                catch
                {

                }
                long time = (long)((DateTime.Now - dtStart).TotalMilliseconds);
                if (time > 100)
                {

                }
            }
            return dt;
        }

        public DataSet ExecDataSet()
        {
            DataSet set = new DataSet();

            return set;
        }

        public object ExecScalar(string sql)
        {
            if (!CheckConnection())
            {
                return null;
            }
            try
            {
                using (Locker.Lock(instances))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandTimeout = queryTimeOut;
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    object obj = cmd.ExecuteScalar();
                    return obj;
                }

            }
            catch
            {
                return null;
            }
        }

        public int ExecuteNQ(string sql, List<SqlParameter> parameters = null)
        {
            if (!CheckConnection())
            {
                return 0;
            }
            try
            {
                using (Locker.Lock(instances))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    int obj;
                    if (parameters != null && parameters.Count > 0)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                        obj = cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        obj = cmd.ExecuteNonQuery();
                    }
                    instances.Remove(currentInstanceId.Value);
                    return obj;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int ExecuteStoredProcedureNoData(string sql, List<SqlParameter> parameters, int retries)
        {
            if (!CheckConnection())
                return -1;
            DateTime dtStart = DateTime.Now;
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = queryTimeOut;
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sql;
            List<SqlParameter> backParams = null;
            bool retry = false;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters.ToArray());
                backParams = new List<SqlParameter>();
                foreach (SqlParameter p in parameters)
                {
                    backParams.Add(new SqlParameter(p.ParameterName, p.SqlDbType, p.Size, p.Direction, p.IsNullable, p.Precision, p.Scale, p.SourceColumn, p.SourceVersion, p.Value));
                }
            }
            int res = 0;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                if (sqlex.Number == 1205 || sqlex.Number == -2)
                {
                    if (retries < 3)
                    {
                        retry = true;
                        if (sqlex.Number == -2)
                        {
                            queryTimeOut *= 2;
                        }
                    }
                    else
                        Utils.Log(string.Format("Retrying DBHelper:ExecuteStoredProcedureNoData : {0}, Exception {1}", sql, sqlex), "StoreProcedureException.Log");
                }
                else
                {
                    Utils.Log(string.Format("DBHelper:ExecuteUpdate : {0}, Exception {1}", sql, sqlex), "StoreProcedureException.Log");
                    throw sqlex;
                }
            }
            catch (Exception ex)
            {
                res = -1;
                Utils.Log("DBHelper:ExecuteStoredProcedureNoData : {ex}", "StoreProcedureException.Log");
            }
            finally
            {
                cmd.Dispose();
            }
            if (retry)
                return ExecuteStoredProcedureNoData(sql, backParams, retries + 1);
            long dt = (long)((DateTime.Now - dtStart).TotalMilliseconds);
            Utils.Log($"SQL SPND\t{dt}\t{sql.Replace("\r", "[$r]").Replace("\n", "[$n]").Replace("\t", "[$t]")}", "StoreProcedureException.Log");
            return res;
        }




    }
}
