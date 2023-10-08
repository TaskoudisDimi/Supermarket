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
        [DatabaseColumn(IsPrimaryKey = true, IsEncrypted = false)]
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProdQty { get; set; }
        public int ProdPrice { get; set; }
        public int ProdCatID { get; set; }
        public string ProdCat { get; set; }
        public DateTime Date { get; set; }


    }
}
