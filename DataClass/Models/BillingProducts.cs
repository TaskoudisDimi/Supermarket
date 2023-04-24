using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class BillingProducts
    {
        public int Id { get; set; }
        public string ProdName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public int Total { get; set; }
    }
}
