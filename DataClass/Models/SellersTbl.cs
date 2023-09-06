using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    [TableName("SellersTbl")]
    public class SellersTbl
    {
        public int SellerId { get; set; }
        public string SellerUserName { get; set; }
        public byte SellerPass { get; set; }
        public string SellerName { get; set; }
        public int SellerAge { get; set; }
        public int SellerPhone { get; set; }
        public string Address { get; set; }
        public bool Active { get; set; }
        public Image image { get; set; }
        public DateTime Date { get; set; }
    }
}
