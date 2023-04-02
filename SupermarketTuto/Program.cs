using DataClass;
using SupermarketTuto.Forms;
using SupermarketTuto.Forms.AdminForms;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Forms.SellingForms;

namespace SupermarketTuto
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.Run(new MainAdmin());
        }

        // TODO: Build class in order to manage Sql tables, schema etc
        // TODO: Use TCP / UDP sending/receiving packet  
        // TODO: Build API 
        // TODO: Manage Threads
        // TODO: Use custom events

    }
}