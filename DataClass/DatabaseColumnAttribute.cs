using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class DatabaseColumnAttribute : Attribute
    {
        public bool IsPrimaryKey { get; set; }
        public bool IsEncrypted { get; set; }

        public DatabaseColumnAttribute(bool isPrimaryKey = true, bool isEncrypted = false)
        {
            IsPrimaryKey = isPrimaryKey;
            IsEncrypted = isEncrypted;
        }

    }
}
