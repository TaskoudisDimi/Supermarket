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

        // TODO: Paging
        // TODO: Insert data from store procedures
        // TODO: Manage Threads
        // TODO: Use Interface / abstract
        // TODO: Use custom events
        // TODO: Use TCP / UDP sending/receiving packet  
        // TODO: Build API

    }
}