using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class SchemaColumn
    {
        public string ColumnName { get; }
        public SqlDbType DataType { get; }

        public SchemaColumn(string columnName, SqlDbType dataType)
        {
            ColumnName = columnName;
            DataType = dataType;
        }

        public SchemaColumn(string columnName, SqlDbType dataType, int size, bool nullable)
        {
            ColumnName = columnName;
            DataType = dataType;
            // Only applies to NVarChar columns
            if (dataType == SqlDbType.NVarChar)
            {
                DataType = SqlDbType.NVarChar;
                Size = size;
            }
            Nullable = nullable;
        }

        public int Size { get; }

        public bool Nullable { get; }
    }
}
