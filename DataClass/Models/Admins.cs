using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    [TableName("Admins")]
    public class Admins
    {
        [DatabaseColumn(IsPrimaryKey = true, IsEncrypted = false)]
        public int Id { get; set; }

        public string UserName { get; set; }

        [DatabaseColumn(IsPrimaryKey = false, IsEncrypted = true)]
        public string Password { get; set; }

        public bool Active { get; set; }

    }
}
