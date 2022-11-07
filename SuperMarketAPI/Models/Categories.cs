using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMarketAPI.Models
{
    public class Categories
    {
        public int Catid { get; set; }
        public string CatName { get; set; }
        public string CatDesc { get; set; }
        public DateTime Date { get; set; }
    }
}