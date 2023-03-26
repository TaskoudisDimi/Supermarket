using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataClass
{
    public class SqlConnect
    {

        public static SqlConnection con = new SqlConnection();

        public DataTable table = new DataTable();

        public SqlConnect()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["smarketdb"].ConnectionString;
        }

        public void OpenCon()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CloseCon()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void retrieveData(string command)
        {
            try
            {
                OpenCon();
                SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseCon();
            }
        }

        public void commandExc(string command)
        {
            try
            {
                
                SqlCommand sqlcomm = new SqlCommand(command, con);
                OpenCon();
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseCon();
            }
        }

        public void backup(string path)
        {
            try
            {
                OpenCon();
                string query = "BACKUP DATABASE smarketdb TO DISK = '" + path + "\\backupfile.bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of Testdb';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("BackUp seccess!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseCon();
            }
        }

        public void search(string text, string sql)
        {
            try
            {
                OpenCon();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseCon();
            }
        }


        public void pagingData(string command, int startRecord, int maxRecord)
        {
            try
            {
                table.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                adapter.Fill(startRecord, maxRecord, table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void saveImage(byte[] imageData, string query)
        {
            OpenCon();
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.Add("@ImageData", SqlDbType.VarBinary, -1).Value = imageData;
            command.ExecuteNonQuery();
            CloseCon();
        }
    }
}