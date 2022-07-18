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

        public SqlConnect()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString;
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


        public void backup(string path)
        {
            con.Open();
            string query = "BACKUP DATABASE smarketdb TO DISK = '" + path + "\\backupfile.bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of Testdb';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("BackUp seccess!");
        }


        public void search(string text)
        {
            con.Open();
            string query = "Select * From ProductTbl where ProdId like '%" + text + "%'" + "or ProdName like '%" + text + "%'" + "or ProdQty like '%" + text + "%'" + "or ProdPrice like '%" + text + "%'" + "or ProdCat like '%" + text + "%'";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);

        }

    }

}
