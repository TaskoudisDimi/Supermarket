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

        public void UpdateTable(string tableName)
        {
            try
            {
                if (cachedTables.ContainsKey(tableName))
                {
                    // Get the latest version of the table from the database
                    DataTable latestTable = new DataTable();
                    string query = $"SELECT * FROM {tableName}";
                    using (connection = new SqlConnection(connectionString))
                    using (command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        adapter = new SqlDataAdapter(command);
                        adapter.Fill(latestTable);
                        DataColumn firstColumnLatest = latestTable.Columns[0];
                        latestTable.PrimaryKey = new DataColumn[] { firstColumnLatest };
                    }

                    // Compare the latest version of the table with the cached version
                    DataTable cachedTable = cachedTables[tableName];
                    bool hasChanges = false;
                    foreach (DataRow latestRow in latestTable.Rows)
                    {
                        DataRow cachedRow = cachedTable.Rows.Find(latestRow["ProdId"]);
                        if (cachedRow == null || !latestRow.ItemArray.SequenceEqual(cachedRow.ItemArray))
                        {
                            // The row has been added or modified
                            cachedTable.Rows.Add(latestRow.ItemArray);
                            hasChanges = true;
                        }
                    }
                    foreach (DataRow cachedRow in cachedTable.Rows)
                    {
                        DataRow latestRow = latestTable.Rows.Find(cachedRow["ProdId"]);
                        if (latestRow == null)
                        {
                            // The row has been deleted
                            cachedRow.Delete();
                            cachedRow.AcceptChanges();
                            hasChanges = true;
                        }
                    }

                    // If there are changes, raise an event to notify the UI to refresh the table
                    if (hasChanges)
                    {
                        TableChanged?.Invoke(tableName);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        // Define an event to notify the UI when a table has changed
        public event Action<string> TableChanged;


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
        public void DeleteData(DataRow row, Type type)
        {
            try
            {
                adapter.SelectCommand.Connection.ConnectionString = connectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ProductTbl", connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    DataRow[] rowsToDelete = null;
                    if (type.Name == "Products")
                    {
                        rowsToDelete = table.Select($"ProdId = {row["ProdId"]}");
                    }
                    else if (type.Name == "Categories")
                    {
                        rowsToDelete = table.Select($"CatId = {row["CatId"]}");
                    }

                    foreach (DataRow rowToDelete in rowsToDelete)
                    {
                        rowToDelete.Delete();
                    }

                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update(table);
                }
            }
            catch
            {

            }


        }
    }
}
