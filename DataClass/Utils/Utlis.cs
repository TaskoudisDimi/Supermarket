using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SupermarketTuto.Utils
{
    public static class Utlis
    {
        private const int MAX_FILE_SIZE = 4194304; // 4 MBytes
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

        public static void Log(string msg, string fileName = null)
        {
            try
            {
                string final_path = null;
                // Log is by default stored in server files under Logs folder.

                final_path = Directory.GetCurrentDirectory() + "\\" + fileName;
                EnsureFileSize(final_path);
                StreamWriter sw = new StreamWriter(final_path, true);
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + msg);
                sw.Close();
            }
            catch (Exception ex) 
            {
                
            }
        }

        private static void EnsureFileSize(string fname)
        {
            FileInfo finfo = null;
            try
            {
                finfo = new System.IO.FileInfo(fname);
                long len = finfo.Length;
                if (len < MAX_FILE_SIZE)
                    return;
                string ext = string.Format(".{0}", Path.GetExtension(fname));
                string newFName = fname.Replace(ext, string.Format("{0}{1}", DateTime.Now.ToString("_yy_MM_dd_HH_mm_ss_"), ext));
                File.Move(fname, newFName);
            }
            catch (Exception ex)
            {
            }
        }

        public static String IntToString(int value)
        {
            return value.ToString();
        }
    }
}
