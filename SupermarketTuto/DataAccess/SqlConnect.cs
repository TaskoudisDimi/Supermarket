using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;



namespace SupermarketTuto.DataAccess
{
    public class SqlConnect
    {

        static string constring = ConfigurationManager.ConnectionStrings["smarketdb"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);




    }

}
