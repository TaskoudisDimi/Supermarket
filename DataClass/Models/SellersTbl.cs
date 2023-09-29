using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    [TableName("SellersTbl")]
    public class SellersTbl
    {
        [DatabaseColumn(IsPrimaryKey = true, IsEncrypted = false)]
        public int SellerId { get; set; }
        public string SellerUserName { get; set; }

        [DatabaseColumn(IsPrimaryKey = false, IsEncrypted = true)]
        public string SellerPass { get; set; }
        public string SellerName { get; set; }
        public int SellerAge { get; set; }
        public int SellerPhone { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public bool Active { get; set; }
        public byte[] image { get; set; }
        
    }
}
