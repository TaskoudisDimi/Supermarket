using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Transactions
    {

        SqlConnection con = new SqlConnection();
        public DataTable table = new DataTable();
        public SqlDataAdapter adapterPage = new SqlDataAdapter();

        public Transactions()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString;
        }


        public int ExecuteSqlTransaction(string cmd)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                //command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = cmd;

                    int res = command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                    return res;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                    return -1;
                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
        }

        private void OpenConnection()
        {

        }

        private void CloseConnection()
        {

        }


    }
}
