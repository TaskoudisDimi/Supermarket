using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Sellers
    {
        public int SellerId { get; set; }
        public string SellerUserName { get; set; }
        public string SellerPass { get; set; }
        public string SellerName { get; set; }
        public int SellerAge { get; set; }
        public int SellerPhone { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public bool Active { get; set; }
        public Image image { get; set; }
    }
}
