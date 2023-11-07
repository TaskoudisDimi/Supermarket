using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CheckDatabase
    {
        private static CheckDatabase instance = null;
        private static readonly object padlock = new object();
        public static CheckDatabase Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new CheckDatabase();
                    }
                    return instance;
                }
            }
        }







    }
}
