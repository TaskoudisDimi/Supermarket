using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using SupermarketTuto.Forms;
using SupermarketTuto.Forms.AdminForms;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Forms.SellingForms;
using System.Configuration;
using System.Data.SqlClient;

namespace SupermarketTuto
{
    internal static class Program
    {

        //TODO: Import Export excel/csv
        //TODO: Check Database, Restore,Backup etc.
        //TODO: Build API 
        //TODO: Upload / Download files 
        //TODO: Updates


        [STAThread]
        static void Main()
        {

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            if (!Utils.Utils.IsConnectedToInternet())
            {
                MessageBox.Show("There is no internet connection", Constants.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Application.Run(new MainAdmin());   
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            // Log the exception details into a SQL Server table
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["smarketdb"].ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Exceptions (Message, StackTrace, Date) VALUES (@ErrorMessage, @StackTrace, @Date)", connection);
                command.Parameters.AddWithValue("@ErrorMessage", ex.Message);
                command.Parameters.AddWithValue("@StackTrace", ex.StackTrace);
                command.Parameters.AddWithValue("@Date", DateTime.Now);
                command.ExecuteNonQuery();
            }

            // Display a message or perform other necessary actions
            ExceptionForm form = new ExceptionForm(ex.Message, ex.StackTrace);
            form.Show();
        }
    }
}


