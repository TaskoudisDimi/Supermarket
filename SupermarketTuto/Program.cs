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

        
        // TODO: Insert data from store procedures
        // TODO: Manage Threads
        // TODO: Use custom events
        // TODO: Use TCP / UDP sending/receiving packet  
        // TODO: Build API 
        // TODO: Display Image to db

    }
}