using SupermarketTuto.Forms;

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
            Application.Run(new SupermarketTuto.SellingForm());

        }
    }
}