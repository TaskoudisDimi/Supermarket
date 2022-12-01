using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketTuto.Utils
{
    public class Utlis
    {

        public static string HashCode(string pass)
        {
            return Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{pass}"));
        }

        public static string HashCode2(string pass2)
        {
            using (SHA1Managed sha = new SHA1Managed())
            {
                var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(pass2));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            };
        }

        public String IntToString (int value)
        {
            return value.ToString();
        }



    }
}
