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
        public int Id { get; set; }

        [FieldSize(Size:200)]
        public string UserName { get; set; }

        [Encrypted]

        [FieldSize(Size: 200)]
        public string Password { get; set; }

        public bool Active { get; set; }

        [NullableField(true)]
        public bool isSuperAdmin { get; set; }

    }
}
