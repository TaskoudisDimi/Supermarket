using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;
using SupermarketTuto.Utils;

namespace ClassLibrary1
{
    public class CheckDatabase
    {

        /// <summary>
        /// Size of field, Null, Type (int, float, etc.), Primary key (and identity), Binary (Images)
        /// </summary>

        static List<string> CheckedTabledStates = new List<string>();

        public CheckDatabase()
        {
            CheckTabledState();
        }

        public void CheckTabledState()
        {
            TableNameAttribute tableAttribute = (TableNameAttribute)Attribute.GetCustomAttribute(GetType(), typeof(TableNameAttribute));

            if (tableAttribute == null)
            {
                return;
            }
            string TableName = tableAttribute.TableName;
            if (CheckedTabledStates.Contains(TableName))
                return;
            PropertyInfo[] properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (!TableExists(TableName))
            {
                CreateTable(TableName, properties);
            }
            else
            {
                CheckExistingAndUpdateTable(TableName);
            }
            CheckedTabledStates.Add(TableName);
        }

        public SchemaTable GetModelSchemaTable()
        {
            TableNameAttribute tableAttribute = (TableNameAttribute)Attribute.GetCustomAttribute(GetType(), typeof(TableNameAttribute));

            if (tableAttribute == null)
            {
                return null; // Handle when the table attribute is not found
            }

            string tableName = tableAttribute.TableName;
            PropertyInfo[] properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            List<SchemaColumn> columns = new List<SchemaColumn>();

            foreach (var property in properties)
            {
                // Extract column information from the attribute
                string columnName = property.Name; // Get the property name as column name by default

                // Check if the FieldSizeAttribute is applied to specify the size of the field
                int size = 0; // Default size if not specified
                bool nullValue = false;
                var fieldSizeAttribute = (FieldSizeAttribute)Attribute.GetCustomAttribute(property, typeof(FieldSizeAttribute));
                if (fieldSizeAttribute != null)
                {
                    size = fieldSizeAttribute.Size;
                }
                var nullableFieldAttribute = (NullableFieldAttribute)Attribute.GetCustomAttribute(property, typeof(NullableFieldAttribute));
                if (nullableFieldAttribute != null)
                {
                    nullValue = nullableFieldAttribute.Nullable;
                }

                // Create a SchemaColumn based on the attributes
                SqlDbType dataType = ConvertToSqlDbType(property.PropertyType);

                SchemaColumn column = new SchemaColumn(columnName, dataType, size, nullValue);
                columns.Add(column);

            }

            SchemaTable modelSchemaTable = new SchemaTable(tableName, columns);
            return modelSchemaTable;
        }


        // Method to convert C# type to SqlDbType (Modify based on your requirements)
        private SqlDbType ConvertToSqlDbType(Type type)
        {
            // Implement conversion logic from C# type to SqlDbType
            // This is a simple example, you may need to handle various types appropriately
            if (type == typeof(int))
            {
                return SqlDbType.Int;
            }
            else if (type == typeof(string))
            {
                return SqlDbType.NVarChar; // Modify according to your needs
            }
            else if (type == typeof(bool))
            {
                return SqlDbType.Bit; // Modify according to your needs
            }
            else if (type == typeof(byte))
            {
                return SqlDbType.Binary; // Modify according to your needs
            }

            // Return a default SqlDbType for unsupported types
            return SqlDbType.VarChar; // For example
        }

        private SchemaTable GetSqlSchemaTable(string tableName)
        {
            List<SchemaColumn> columns = new List<SchemaColumn>();
            //Find the table from SQL server
            string sql = $@"SELECT ORDINAL_POSITION, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, " +
                $@" IS_NULLABLE FROM smarketdb.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'";
            DataTable existingSQLTable = DataContext.Instance.SelectDataTable(sql);
            if (existingSQLTable != null)
            {
                foreach (DataRow row in existingSQLTable.Rows)
                {
                    string columnName = row["COLUMN_NAME"].ToString();
                    SqlDbType dataType = GetSqlType(row["DATA_TYPE"].ToString());
                    int? characterMaxLength = row["CHARACTER_MAXIMUM_LENGTH"] != DBNull.Value ?
                        Convert.ToInt32(row["CHARACTER_MAXIMUM_LENGTH"]) : (int?)null;
                    bool isNullable = row["IS_NULLABLE"].ToString().ToLower() == "yes"; // Assuming IS_NULLABLE is 'YES' or 'NO'
                    // Create a SchemaColumn object for each existing column in the SQL Server table
                    SchemaColumn column;
                    if (characterMaxLength.HasValue && dataType == SqlDbType.NVarChar)
                    {
                        column = new SchemaColumn(columnName, dataType, characterMaxLength.Value, isNullable);
                    }
                    else
                    {
                        column = new SchemaColumn(columnName, dataType);
                    }
                    columns.Add(column);
                }
            }
            SchemaTable sqlSchemaTable = new SchemaTable(tableName, columns);
            return sqlSchemaTable;
        }

        private void CheckExistingAndUpdateTable(string tableName)
        {

            SchemaTable sqlSchemaTable = GetSqlSchemaTable(tableName);

            SchemaTable modelSchemaTable = GetModelSchemaTable();

            // Compare the columns between existingSchemaTable and modelSchemaTable
            if (CompareAndUpdateSchemaTables(sqlSchemaTable, modelSchemaTable))
            {
                //The tables are the same 
            }
            else
            {
                //The tables are different 

            }

        }

        private bool CompareAndUpdateSchemaTables(SchemaTable sqlSchemaTable, SchemaTable modelSchemaTable)
        {

            // Compare Columns count
            if (modelSchemaTable.Columns.Count != sqlSchemaTable.Columns.Count)
            {
                // Number of columns are different
                // Find the difference and add the column
                return false;
            }

            // Compare each column
            foreach (var column1 in sqlSchemaTable.Columns)
            {
                // Find matching column in schemaTable2 by ColumnName
                var matchingColumn = modelSchemaTable.Columns.FirstOrDefault(c => c.ColumnName == column1.ColumnName);

                if (matchingColumn == null)
                {
                    return false; // Column not found in the other schema
                }
                // Compare individual column properties (DataType, Size, IsNullable)
                if (matchingColumn.DataType != column1.DataType ||
                    matchingColumn.Size != column1.Size ||
                    matchingColumn.Nullable != column1.Nullable)
                {
                    string sql = $"ALTER TABLE smarketdb.dbo.{modelSchemaTable.TableName} " +
                        $"ALTER COLUMN {matchingColumn.ColumnName}  {matchingColumn.DataType} {matchingColumn.Nullable}";
                    DataContext.Instance.ExecuteNQ(sql);
                    return false; // Column properties are different
                }
            }

            // All columns match
            return true;
        }


        private bool TableExists(string tableName)
        {
            int result = (int)DataContext.Instance.ExecScalar($@" IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
                                              WHERE TABLE_SCHEMA = 'dbo' AND  TABLE_NAME = '{tableName}'))
                                              BEGIN 
                                                Select 1
	                                          END
                                              ELSE BEGIN
		                                        Select 0
	                                          END");
            bool TableExist = (result == 1);
            return TableExist;
        }

        private void CreateTable(string tableName, PropertyInfo[] properties)
        {
            //            StringBuilder sb = new StringBuilder($"CREATE TABLE [dbo].[{tableName}](\r\n");
            //            string identityField = "";
            //            string TEXTIMAGE_ON = "";
            //            foreach (PropertyInfo p in properties)
            //            {

            //                string type = p.PropertyType.ToString();
            //                string identityText = "";
            //                string fieldName = p.Name;
            //                if (Attribute.IsDefined(p, typeof(JsonPropertyAttribute)))
            //                {
            //                    JsonPropertyAttribute attr = p.GetCustomAttribute<JsonPropertyAttribute>();
            //                    fieldName = attr.PropertyName;
            //                }
            //                if (Attribute.IsDefined(p, typeof(IdentityAttribute)))
            //                {
            //                    identityText = "IDENTITY(1,1)";
            //                    identityField = fieldName;
            //                }
            //                bool isNullable = type.IndexOf("System.Nullable`1") > -1 || Attribute.IsDefined(p, typeof(NullableFieldAttribute));
            //                string nullText = isNullable ? "NULL" : "NOT NULL";
            //                int size = -1;
            //                if (Attribute.IsDefined(p, typeof(FieldSizeAttribute)))
            //                {
            //                    FieldSizeAttribute sizeAttr = p.GetCustomAttribute<FieldSizeAttribute>();
            //                    size = sizeAttr.Size;
            //                }
            //                bool isBinary = Attribute.IsDefined(p, typeof(BinaryFieldAttribute));
            //                string dbType = getDBColumnTypeSize(type, size, isBinary);
            //                if (TEXTIMAGE_ON.Length == 0 && (isBinary || (dbType.StartsWith("[nvarchar]") && size == -1)))
            //                {
            //                    TEXTIMAGE_ON = "TEXTIMAGE_ON[PRIMARY]";
            //                }
            //                System.Diagnostics.Debug.WriteLine($"{type} -> {dbType}");

            //                sb.AppendLine($"[{fieldName}] {dbType} {identityText} {nullText},");
            //            }

            //            if (identityField.Length > 0)
            //            {
            //                sb.AppendLine($@"CONSTRAINT [PKA_{tableName}] PRIMARY KEY CLUSTERED 
            //(

            //    [{identityField}] ASC
            //)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
            //) ON[PRIMARY] {TEXTIMAGE_ON}");
            //            }
            //            System.Diagnostics.Debug.WriteLine(sb.ToString());
            //            DBHelper.ExecuteQuery(sb.ToString());
        }

        private void UpdateTable(string tableName, PropertyInfo[] properties)
        {
            //            DataTable schemaDt = DBHelper.GetDataTable($@"SELECT ORDINAL_POSITION, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
            //       , IS_NULLABLE
            //FROM INFORMATION_SCHEMA.COLUMNS
            //WHERE TABLE_NAME = '{tableName}'");
            //            Dictionary<string, DataRow> rowsDict = new Dictionary<string, DataRow>();
            //            foreach (DataRow dr in schemaDt.Rows)
            //            {
            //                rowsDict[DBHelper.GetStringFromRow(dr, "COLUMN_NAME", "").ToLower()] = dr;
            //            }
            //            foreach (PropertyInfo p in properties)
            //            {


            //                string type = p.PropertyType.ToString();
            //                bool isIdentity = Attribute.IsDefined(p, typeof(IdentityAttribute));
            //                bool isBinary = Attribute.IsDefined(p, typeof(BinaryFieldAttribute));
            //                bool isNullable = type.IndexOf("System.Nullable`1") > -1 || Attribute.IsDefined(p, typeof(NullableFieldAttribute));
            //                string nullText = isNullable ? "NULL" : "NOT NULL";
            //                string fieldName = p.Name;
            //                int size = -1;
            //                if (Attribute.IsDefined(p, typeof(JsonPropertyAttribute)))
            //                {
            //                    JsonPropertyAttribute attr = p.GetCustomAttribute<JsonPropertyAttribute>();
            //                    fieldName = attr.PropertyName;
            //                }
            //                if (Attribute.IsDefined(p, typeof(FieldSizeAttribute)))
            //                {
            //                    FieldSizeAttribute sizeAttr = p.GetCustomAttribute<FieldSizeAttribute>();
            //                    size = sizeAttr.Size;
            //                }
            //                string dbType = getDBColumnTypeSize(type, size, isBinary);
            //                if (rowsDict.ContainsKey(fieldName.ToLower()))
            //                {
            //                    int sizeDB = DBHelper.GetIntFromRow(rowsDict[fieldName.ToLower()], "CHARACTER_MAXIMUM_LENGTH", -1);
            //                    if (sizeDB < size)
            //                    {
            //                        DBHelper.ExecuteQuery($"ALTER TABLE dbo.{tableName} ALTER COLUMN {fieldName}  {dbType} {nullText}");
            //                    }
            //                }
            //                else
            //                {
            //                    DBHelper.ExecuteQuery($"ALTER TABLE dbo.{tableName} ADD {fieldName} {dbType} {nullText}");
            //                }
            //            }

            //            schemaDt.Dispose();

        }

        private string getDBColumnType(string type, bool isEncrypted)
        {
            string dbType = "";
            switch (type)
            {
                case "System.Int32":
                case "System.Int64":
                case "System.Nullable`1[System.Int32]":
                case "System.Nullable`1[System.Int64]":
                    dbType = "[int]";
                    break;
                case "System.DateTime":
                case "System.Nullable`1[System.DateTime]":
                    dbType = "[DateTime]";
                    break;
                case "System.Float":
                case "System.Double":
                case "System.Decimal":
                case "System.Nullable`1[System.Float]":
                case "System.Nullable`1[System.Double]":
                case "System.Nullable`1[System.Decimal]":
                    dbType = "[float]";
                    break;
                case "System.Boolean":
                case "System.Nullable`1[System.Boolean]":
                    dbType = "[bit]";
                    break;
                case "System.String":
                case "System.Nullable`1[System.String]":
                    {
                        if (isEncrypted)
                        {
                            dbType = $"[varbinary](max)";
                        }
                        else
                        {
                            dbType = $"[nvarchar](max)";
                        }
                    }
                    break;
            }
            return dbType;
        }

        private SqlDbType GetSqlType(string type)
        {
            if (type.Contains("int"))
            {
                return SqlDbType.Int;
            }
            else if (type.Contains("nvarchar"))
            {
                return SqlDbType.NVarChar;
            }
            else if (type.Contains("decimal"))
            {
                return SqlDbType.Decimal;
            }
            else if (type.Contains("varchar"))
            {
                return SqlDbType.VarChar;
            }
            else if (type.Contains("bit"))
            {
                return SqlDbType.Bit;
            }
            else if (type.Contains("byte"))
            {
                return SqlDbType.VarBinary;
            }
            else if (type.Contains("date"))
            {
                return SqlDbType.Date;
            }
            else if (type.Contains("datetime"))
            {
                return SqlDbType.DateTime;
            }
            else
            {
                return SqlDbType.Text;
            }
        }
    }
}

