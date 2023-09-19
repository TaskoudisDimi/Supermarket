using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class TableNameAttribute : Attribute
    {
        string _tableName = "";

        public string TableName { get => _tableName; set => _tableName = value; }

        public TableNameAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
