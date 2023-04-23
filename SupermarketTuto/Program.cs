using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using SupermarketTuto.Forms;
using SupermarketTuto.Forms.AdminForms;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Forms.SellingForms;
using SchemaColumn = DataClass.SchemaColumn;
using SchemaTable = DataClass.SchemaTable;

namespace SupermarketTuto
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {

            Application.Run(new MainAdmin());
        }

        // TODO: Uploade / Download files 
        // TODO: Autorefresh
        // TODO: Use TCP / UDP sending/receiving packet  
        // TODO: Manage Threads, Lock Treads etc.
        // TODO: Build API 
        // TODO: Call API (json && xml)
    }
}


