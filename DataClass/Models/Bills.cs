using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Bills
    {
        public int BillId { get; set; }
        public string Comments { get; set; }
        public string SellerName { get; set; }
        public DateTime Date { get; set; }
        public int TotAmt { get; set; }

    }
}
