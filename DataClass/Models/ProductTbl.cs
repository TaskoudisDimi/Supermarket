using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.Models
{
    [TableName("ProductTbl")]
    public class ProductTbl : Excel
    {
        [PrimaryKey]
        public int ProdId { get; set; }

        [FieldSize(Size: 200)]
        public string ProdName { get; set; }
        public int ProdQty { get; set; }
        public int ProdPrice { get; set; }
        public int ProdCatID { get; set; }

        [FieldSize(Size: 200)]
        public string ProdCat { get; set; }
        public DateTime Date { get; set; }

    }
}
