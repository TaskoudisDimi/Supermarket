using SupermarketTuto.Forms;
using SupermarketTuto.Forms.AdminForms;
using SupermarketTuto.Forms.SellingForms;

namespace SupermarketTuto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            Application.Run(new MainSelling());

        }
    }
}