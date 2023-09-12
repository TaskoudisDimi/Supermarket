using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    [TableName("BillTbl")]
    public class BillTbl
    {
        public int BillId { get; set; }
        public string Comments { get; set; }
        public string SellerName { get; set; }
        public DateTime Date { get; set; }
        public int TotAmt { get; set; }
        public string ProductIDs { get; set; }
        public string CategoryIDs { get; set; }

    }
}
