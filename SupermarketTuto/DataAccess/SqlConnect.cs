using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;


namespace SupermarketTuto.DataAccess
{
    public class SqlConnect
    {



        SqlConnection con = new SqlConnection();
        public DataTable table = new DataTable();

        private DbConnection DatabaseConnection = null;
        private DbTransaction DatabaseTransaction = null;


        public SqlConnect()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString;
            OpenConnection();
        }


        private void OpenConnection()
        {
            if (DatabaseConnection == null)
            {

            }
        }

        public void retrieveData(string command)
        {
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        public void commandExc(string command)
        {
            try
            {
                con.Open();
                SqlCommand sqlcomm = new SqlCommand(command, con);

                int rowInfected = sqlcomm.ExecuteNonQuery();
                if (rowInfected > 0)
                {
                    Console.WriteLine("Success to connect with db!");
                }
                else
                {
                    Console.WriteLine("Fail to connect with db!");
                }
            }
            catch (Exception ex)
            {

            }
        }


    }

}
