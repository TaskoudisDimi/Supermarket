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
        [PrimaryKey]
        public int BillId { get; set; }

        [FieldSize(Size: 200)]
        public string Comments { get; set; }

        [FieldSize(Size: 200)]
        public string SellerName { get; set; }

        public DateTime Date { get; set; }
        public int TotAmt { get; set; }

        [FieldSize(Size: 200)]
        public string ProductIDs { get; set; }

        [FieldSize(Size: 200)]
        public string CategoryIDs { get; set; }

    }
}
