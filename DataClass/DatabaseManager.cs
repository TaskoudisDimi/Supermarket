using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataClass
{
    public class DatabaseManager
    {
        private string connectionString; // Your SQL Server connection string

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CheckSchema()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataTable schema = connection.GetSchema("Tables");

                List<string> tableNames = new List<string>();
                foreach (DataRow row in schema.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    tableNames.Add(tableName);
                }

                // Check each table
                CheckTable("Table1", tableNames, connection);
                CheckTable("Table2", tableNames, connection);
                CheckTable("Table3", tableNames, connection);

                // Add more tables as needed

                connection.Close();
            }
        }

        private void CheckTable(string tableName, List<string> tableNames, SqlConnection connection)
        {
            if (!tableNames.Contains(tableName))
            {
                // Table is missing, create it
                string query = "CREATE TABLE " + tableName + " (ID INT PRIMARY KEY, Name VARCHAR(50))";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            else
            {
                // Table exists, check columns
                DataTable columnsSchema = connection.GetSchema("Columns", new string[] { null, null, tableName });

                bool idColumnExists = false;
                bool nameColumnExists = false;

                foreach (DataRow row in columnsSchema.Rows)
                {
                    string columnName = row["COLUMN_NAME"].ToString();
                    if (columnName == "ID")
                    {
                        idColumnExists = true;
                    }
                    else if (columnName == "Name")
                    {
                        nameColumnExists = true;
                    }
                }

                if (!idColumnExists)
                {
                    // ID column is missing, create it
                    string query = "ALTER TABLE " + tableName + " ADD ID INT PRIMARY KEY";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }

                if (!nameColumnExists)
                {
                    // Name column is missing, create it
                    string query = "ALTER TABLE " + tableName + " ADD Name VARCHAR(50)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
