using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    [TableName("Admins")]
    public class Admins : CheckDatabase
    {
        [PrimaryKey]
        [DatabaseColumn(isPrimaryKey:true)]
        public int Id { get; set; }

        [FieldSize(Size:50)]
        public string UserName { get; set; }

        [DatabaseColumn(isEncrypted:true)]
        [FieldSize(Size: 200)]
        public string Password { get; set; }

        public bool Active { get; set; }

        [NullableField(true)]
        public bool isSuperAdmin { get; set; }

    }
}
