using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Bills
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public string SellName { get; set; }
        public DateTime BillDate { get; set; }
        public int TotAmt { get; set; }

    }
}
