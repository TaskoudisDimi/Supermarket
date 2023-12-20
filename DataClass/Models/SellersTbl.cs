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
        [PrimaryKey]
        public int SellerId { get; set; }

        [FieldSize(Size: 200)]
        public string SellerUserName { get; set; }

        [Encrypted]
        [FieldSize(Size: 200)]
        public string SellerPass { get; set; }

        [FieldSize(Size: 200)]
        public string SellerName { get; set; }
        public int SellerAge { get; set; }
        public int SellerPhone { get; set; }
        public DateTime Date { get; set; }

        [FieldSize(Size: 200)]
        public string Address { get; set; }
        public bool Active { get; set; }

        [Image]
        public byte[] image { get; set; }
        
    }
}
