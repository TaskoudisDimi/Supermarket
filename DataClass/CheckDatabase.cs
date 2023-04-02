using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CheckDatabase
    {
        private readonly string connectionString;

        public CheckDatabase(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CheckSchema(List<SchemaTable> Table)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //var schemaTables = GetSchemaTables(connection);
                var tables = Table;
                foreach (var schemaTable in tables)
                {
                    if (!TableExists(connection, schemaTable.TableName))
                    {
                        CreateTable(connection, schemaTable);
                    }
                    else
                    {
                        var existingColumns = GetTableColumns(connection, schemaTable.TableName);
                        foreach (var schemaColumn in schemaTable.Columns)
                        {
                            if (!existingColumns.Contains(schemaColumn.ColumnName))
                            {
                                AddColumn(connection, schemaTable.TableName, schemaColumn);
                            }
                        }
                    }
                }
            }
        }

        private List<SchemaTable> GetSchemaTables(SqlConnection connection)
        {
            // This method should return a list of SchemaTable objects that define
            // the desired schema for the database.
            // For simplicity, we'll hard-code the schema tables here.
            return new List<SchemaTable>()
            {
                new SchemaTable("Customers", new List<SchemaColumn>()
                {
                    new SchemaColumn("Id", SqlDbType.Int),
                    new SchemaColumn("Name", SqlDbType.NVarChar, 50),
                    new SchemaColumn("Email", SqlDbType.NVarChar, 100)
                }),
                new SchemaTable("Orders", new List<SchemaColumn>()
                {
                    new SchemaColumn("Id", SqlDbType.Int),
                    new SchemaColumn("CustomerId", SqlDbType.Int),
                    new SchemaColumn("OrderDate", SqlDbType.DateTime),
                    new SchemaColumn("TotalAmount", SqlDbType.Decimal)
                })
            };
        }

        private bool TableExists(SqlConnection connection, string tableName)
        {
            using (var command = new SqlCommand($"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'", connection))
            {
                var count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private List<string> GetTableColumns(SqlConnection connection, string tableName)
        {
            var columns = new List<string>();
            using (var command = new SqlCommand($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        columns.Add(reader.GetString(0));
                    }
                }
            }
            return columns;
        }

        private void CreateTable(SqlConnection connection, SchemaTable schemaTable)
        {
            var columnsSql = string.Join(", ", schemaTable.Columns.ConvertAll(c => $"{c.ColumnName} {GetSqlType(c)}"));
            var createTableSql = $"CREATE TABLE {schemaTable.TableName} ({columnsSql})";
            using (var command = new SqlCommand(createTableSql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void AddColumn(SqlConnection connection, string tableName, SchemaColumn schemaColumn)
        {
            var addColumnSql = $"ALTER TABLE {tableName} ADD {schemaColumn.ColumnName} {GetSqlType(schemaColumn)}";
            using (var command = new SqlCommand(addColumnSql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private string GetSqlType(SchemaColumn schemaColumn)
        {
            if (schemaColumn.DataType == SqlDbType.NVarChar)
            {
                return $"{schemaColumn.DataType}(max)";
            }
            else if (schemaColumn.DataType == SqlDbType.Decimal)
            {
                return $"{schemaColumn.DataType}(18, 2)";
            }
            else
            {
                return schemaColumn.DataType.ToString();
            }
        }
        private List<SchemaTable> GetSchemaTables()
        {
            var tables = new List<SchemaTable>();

            // Define the schema for the 'Customers' table
            var customersColumns = new List<SchemaColumn>
    {
        new SchemaColumn("CustomerID", SqlDbType.Int),
        new SchemaColumn("CustomerName", SqlDbType.NVarChar, 50),
        new SchemaColumn("ContactName", SqlDbType.NVarChar, 50),
        new SchemaColumn("Country", SqlDbType.NVarChar, 50),
    };
            var customersTable = new SchemaTable("Customers", customersColumns);
            tables.Add(customersTable);

            // Define the schema for the 'Orders' table
            var ordersColumns = new List<SchemaColumn>
    {
        new SchemaColumn("OrderID", SqlDbType.Int),
        new SchemaColumn("CustomerID", SqlDbType.Int),
        new SchemaColumn("OrderDate", SqlDbType.DateTime),
        new SchemaColumn("ShippedDate", SqlDbType.DateTime),
        new SchemaColumn("ShipCountry", SqlDbType.NVarChar, 50),
    };
            var ordersTable = new SchemaTable("Orders", ordersColumns);
            tables.Add(ordersTable);

            // Define the schema for the 'OrderDetails' table
            var orderDetailsColumns = new List<SchemaColumn>
    {
        new SchemaColumn("OrderID", SqlDbType.Int),
        new SchemaColumn("ProductID", SqlDbType.Int),
        new SchemaColumn("UnitPrice", SqlDbType.Decimal),
        new SchemaColumn("Quantity", SqlDbType.Int),
        new SchemaColumn("Discount", SqlDbType.Decimal),
    };
            var orderDetailsTable = new SchemaTable("OrderDetails", orderDetailsColumns);
            tables.Add(orderDetailsTable);

            return tables;
        }


    }

    public class SchemaTable
    {
        public string TableName { get; }
        public List<SchemaColumn> Columns { get; }

        public SchemaTable(string tableName, List<SchemaColumn> columns)
        {
            TableName = tableName;
            Columns = columns;
        }
    }

    public class SchemaColumn
    {
        public string ColumnName { get; }
        public SqlDbType DataType { get; }

        public SchemaColumn(string columnName, SqlDbType dataType)
        {
            ColumnName = columnName;
            DataType = dataType;
        }

        public SchemaColumn(string columnName, SqlDbType dataType, int size)
        {
            ColumnName = columnName;
            DataType = dataType;
            // Only applies to NVarChar columns
            if (dataType == SqlDbType.NVarChar)
            {
                DataType = SqlDbType.NVarChar;
                Size = size;
            }
        }

        public int Size { get; }
    }
}
