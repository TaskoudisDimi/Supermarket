using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace ClassLibrary1
{
    public class DataAccess
    {
        private static DataAccess instance = null;
        private static readonly object padlock = new object();
        private SqlDataAdapter adapter;
        private Dictionary<string, DataTable> cachedTables;
        private DataSet dataSet;
        SqlCommandBuilder builder;
        SqlConnection connection;
        SqlCommand command;
        string connectionString = ConfigurationManager.ConnectionStrings["smarketdb"].ConnectionString;

        public event Action<string> changeTable;

        private DataAccess()
        {
            cachedTables = new Dictionary<string, DataTable>();
        }

        public static DataAccess Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataAccess();
                    }
                    return instance;
                }
            }
        }


        public DataTable GetTable(string tableName)
        {
            if (!cachedTables.ContainsKey(tableName))
            {
                dataSet = new DataSet();
                // Execute the SQL query to retrieve the table data
                string query = $"SELECT * FROM {tableName}";
                using (connection = new SqlConnection(connectionString))
                using (command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    DataColumn firstColumn = table.Columns[0];
                    table.PrimaryKey = new DataColumn[] { firstColumn };
                    cachedTables.Add(tableName, table);
                    dataSet.Tables.Add(table);
                }
            }


            return cachedTables[tableName];
        }

       

        public void CleanDB()
        {
            using (connection = new SqlConnection(connectionString))
            {
                using(command = new SqlCommand("SP_CleanDatabaseTables", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void RestoreDB(string pathDB)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand useMaster = new SqlCommand("USE master", connection))
                    {
                        useMaster.ExecuteNonQuery();
                    }
                    string restoreDB = $"RESTORE DATABASE smarketdb FROM DISK = '{pathDB}' WITH REPLACE, RECOVERY";
                    using (SqlCommand command = new SqlCommand(restoreDB, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch
            {

            }   
        }

        public void backup(string path)
        {

            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand useMaster = new SqlCommand("USE master", connection))
                    {
                        useMaster.ExecuteNonQuery();
                    }
                    string query = "BACKUP DATABASE smarketdb TO DISK = '" + path + "\\backupfile.bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of Testdb';";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch
            {

            }

        }

    }
}
