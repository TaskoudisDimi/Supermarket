using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DataContext
    {

        private static DataContext instance = null;
        private static readonly object padlock = new object();
        public static int queryTimeOut = 20;
        static Dictionary<int, DataContext> instances = new Dictionary<int, DataContext>();
        private static int instanceID;
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
                    reader = SelectDataReader(sql, parameters);
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

        public int ExecuteNQ(string sql)
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
                    int obj = cmd.ExecuteNonQuery();
                    instances.Remove(currentInstanceId.Value);
                    return obj;
                }

            }
            catch
            {
                return 0;
            }

        }

    }
}
