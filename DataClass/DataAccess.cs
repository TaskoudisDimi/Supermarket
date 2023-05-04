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

namespace ClassLibrary1
{
    public class DataAccess
    {
        private static DataAccess instance = null;
        private static readonly object padlock = new object();
        private BindingSource bindingSource;
        private SqlDataAdapter adapter;
        private Dictionary<string, DataTable> cachedTables;
        private DataSet dataSet;
        SqlCommandBuilder builder;
        SqlConnection connection;
        SqlCommand command;
        string connectionString = ConfigurationManager.ConnectionStrings["smarketdb"].ConnectionString;
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
                    cachedTables.Add(tableName, table);
                    dataSet.Tables.Add(table);
                }
            }

            return cachedTables[tableName];
        }

        public void UpdateData(DataTable Table)
        {
            try
            {
                adapter.SelectCommand.Connection.ConnectionString = connectionString;
                // Create a new SqlCommandBuilder instance and use it to generate the necessary SQL statements to update the database
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    builder = new SqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    // Use the Update method of the SqlDataAdapter to perform the update
                    adapter.Update(Table);
                }
            }
            catch
            {

            }
        }

        public void InsertData(DataTable Table)
        {
            try
            {
                adapter.SelectCommand.Connection.ConnectionString = connectionString;
                // Create a new SqlCommandBuilder instance and use it to generate the necessary SQL statements to update the database
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    builder = new SqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetInsertCommand();
                    // Use the Update method of the SqlDataAdapter to perform the update
                    adapter.Update(Table);
                }
            }
            catch
            {

            }
        }
        public void DeleteData(DataTable Table)
        {
            try
            {
                adapter.SelectCommand.Connection.ConnectionString = connectionString;
                // Create a new SqlCommandBuilder instance and use it to generate the necessary SQL statements to update the database
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    builder = new SqlCommandBuilder(adapter);
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    // Use the Update method of the SqlDataAdapter to perform the update
                    adapter.Update(Table);
                }
            }
            catch
            {

            }
        }


    }

}
