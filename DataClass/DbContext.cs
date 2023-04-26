using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class DbContext
    {
        private static string GetCorrectSQLConnectionString()
        {
            foreach (ConnectionStringSettings item in ConfigurationManager.ConnectionStrings)
            {
                if (item.Name.EndsWith("Properties.Settings.DBConnectionString"))
                    return item.Name;
            }

            throw new Exception("No connection string is set!");
        }


        public SqlConnectionStringBuilder SqlConnection = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings[GetCorrectSQLConnectionString()].ConnectionString);
        private string DataProviderName = ConfigurationManager.ConnectionStrings[GetCorrectSQLConnectionString()].ProviderName;
        private string ConnectionString = ConfigurationManager.ConnectionStrings[GetCorrectSQLConnectionString()].ConnectionString;
        private DbConnection DatabaseConnection = null;
        private DbTransaction DatabaseTransaction = null;



        public DbContext()
        {
            OpenConnection();
        }

        public void Dispose()
        {
            CloseConnection();
        }

        public void OpenConnection()
        {
            if (DatabaseConnection == null)
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(DataProviderName);
                DatabaseConnection = factory.CreateConnection();
                DatabaseConnection.ConnectionString = ConnectionString;
            }

            if (DatabaseConnection != null && DatabaseConnection.State != ConnectionState.Open)
            {
                DatabaseConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (DatabaseConnection != null && DatabaseConnection.State != ConnectionState.Closed)
            {
                DatabaseConnection.Close();
            }
        }

        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadUncommitted)
        {
            int ts = Environment.TickCount;
            OpenConnection();
            if (DatabaseTransaction == null)
            {
                DatabaseTransaction = DatabaseConnection.BeginTransaction(isolationLevel);
            }
        }

        public void CommitTransaction()
        {
            int ts = Environment.TickCount;
            DatabaseTransaction.Commit();
            DatabaseTransaction = null;
        }

        public void RollbackTransaction()
        {

            int ts = Environment.TickCount;
            DatabaseTransaction.Rollback();
            DatabaseTransaction = null;
            
        }



        public object ExecScalar(string cmd)
        {
            int ts = Environment.TickCount;

            using (DbCommand command = DatabaseConnection.CreateCommand())
            {
                try
                {
                    if (DatabaseTransaction != null)
                        command.Transaction = DatabaseTransaction;
                    command.CommandType = CommandType.Text;
                    command.CommandText = cmd;
                    object obj = command.ExecuteScalar();

                    return obj;
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }


        public int ExecNQ(string cmd)
        {
            using (DbCommand command = DatabaseConnection.CreateCommand())
            {
                try
                {
                    if (DatabaseTransaction != null)
                        command.Transaction = DatabaseTransaction;
                    command.CommandType = CommandType.Text;
                    command.CommandText = cmd;
                    int res = command.ExecuteNonQuery();

                    return res;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            return -1;
        }

        public DbDataAdapter GetAdapter()
        {
            DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory(DataProviderName);
            return dbProviderFactory.CreateDataAdapter();
        }


        public DbDataReader ExecDataReader(string cmd)
        {
            using (DbCommand command = DatabaseConnection.CreateCommand())
            {
                if (DatabaseTransaction != null)
                    command.Transaction = DatabaseTransaction;
                command.CommandType = CommandType.Text;
                command.CommandText = cmd;
                DbDataReader reader = command.ExecuteReader();

                return reader;
            }
        }


        public DataTable ExecDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            return dt;
        }


        public DataSet ExecDataSet(string cmd)
        {
            DataSet ds = new DataSet();
            return ds;
        }

    }
}
