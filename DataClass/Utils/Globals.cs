﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketTuto.Utils
{
    public class Globals
    {

        //public static string pathApp = "System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)";
        public static string NameOfSeller = "";

        public enum TypeOfCat
        {
            Cat1 = 0,
            Cat2 = 1,
            Cat3 = 2
        }

        public enum TypeOfUser
        {
            Admin = 0,
            Seller = 1
        }

    }
}
