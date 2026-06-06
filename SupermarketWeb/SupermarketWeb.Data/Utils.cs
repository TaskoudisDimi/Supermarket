using System.Data;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SupermarketWeb.Data;

public static class Utils
{
    private const int MAX_FILE_SIZE = 4_194_304;

    public static void Log(string msg, string? fileName = null)
    {
        try
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), fileName ?? "app.log");
            EnsureFileSize(path);
            File.AppendAllText(path, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: {msg}{Environment.NewLine}");
        }
        catch { }
    }

    private static void EnsureFileSize(string fname)
    {
        try
        {
            var info = new FileInfo(fname);
            if (!info.Exists || info.Length < MAX_FILE_SIZE) return;
            string ext = Path.GetExtension(fname);
            string newName = fname.Replace(ext, $"{DateTime.Now:_yy_MM_dd_HH_mm_ss_}{ext}");
            File.Move(fname, newName);
        }
        catch { }
    }

    public static string GetString(object? val, bool forSql = false, string defaultValue = "")
    {
        if (val is null) return defaultValue;
        string result = val.ToString()?.Trim() ?? defaultValue;
        return forSql ? result.Replace("'", "''") : result;
    }

    public static int GetInt(object? val, int defval = -1)
    {
        if (string.IsNullOrWhiteSpace(GetString(val))) return defval;
        try { return Convert.ToInt32(val); } catch { return defval; }
    }

    public static int? GetNullInt(object? val)
    {
        if (string.IsNullOrWhiteSpace(GetString(val))) return null;
        try { return Convert.ToInt32(val); } catch { return null; }
    }

    public static long GetLong(object? val, long defval = -1)
    {
        if (string.IsNullOrWhiteSpace(GetString(val))) return defval;
        try { return Convert.ToInt64(val); } catch { return defval; }
    }

    public static long? GetNullLong(object? val)
    {
        if (string.IsNullOrWhiteSpace(GetString(val))) return null;
        try { return Convert.ToInt64(val); } catch { return null; }
    }

    public static decimal GetDecimal(object? val, decimal defval = -1)
    {
        if (string.IsNullOrWhiteSpace(GetString(val))) return defval;
        try { return decimal.Parse(val!.ToString()!.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture); }
        catch { return defval; }
    }

    public static decimal? GetNullDecimal(object? val)
    {
        if (string.IsNullOrWhiteSpace(GetString(val))) return null;
        try { return decimal.Parse(GetString(val).Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture); }
        catch { return null; }
    }

    public static double GetDouble(object? val, double defval = -1)
    {
        if (string.IsNullOrWhiteSpace(GetString(val))) return defval;
        try { return double.Parse(val!.ToString()!.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture); }
        catch { return defval; }
    }

    public static float GetFloat(object? val, float defval = -1)
    {
        if (string.IsNullOrWhiteSpace(GetString(val))) return defval;
        try { return float.Parse(val!.ToString()!.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture); }
        catch { return defval; }
    }

    public static bool GetBool(object? val, bool defaultValue = false)
    {
        try
        {
            string s = GetString(val);
            if (s == "1" || s.Equals("true", StringComparison.OrdinalIgnoreCase)) return true;
            if (s == "0" || s.Equals("false", StringComparison.OrdinalIgnoreCase)) return false;
            return bool.Parse(s);
        }
        catch { return defaultValue; }
    }

    public static bool? GetNullBool(object? val)
    {
        if (string.IsNullOrWhiteSpace(GetString(val))) return null;
        return GetBool(val);
    }

    public static DateTime GetDate(object? val, DateTime defaultValue)
    {
        try { return DateTime.Parse(GetString(val)); } catch { return defaultValue; }
    }

    public static DateTime? GetDate(object? val)
    {
        if (string.IsNullOrWhiteSpace(GetString(val))) return null;
        try { return DateTime.Parse(GetString(val)); } catch { return null; }
    }

    public static string HashPassword(string password)
    {
        string salt = BCrypt.Net.BCrypt.GenerateSalt(12);
        return BCrypt.Net.BCrypt.HashPassword(password, salt);
    }

    public static bool VerifyPassword(string entered, string stored)
    {
        try { return BCrypt.Net.BCrypt.Verify(entered, stored); } catch { return false; }
    }

    public static string GetMD5Hash(string input)
    {
        byte[] bytes = MD5.HashData(Encoding.UTF8.GetBytes(input));
        return Convert.ToHexString(bytes).ToLower();
    }

    public static bool IsConnectedToInternet()
    {
        try
        {
            using var ping = new Ping();
            PingReply reply = ping.Send("8.8.8.8", 1000);
            return reply.Status == IPStatus.Success;
        }
        catch { return false; }
    }

    public static string GetLocalIPAddress()
    {
        try
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            return host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork)?.ToString() ?? "0.0.0.0";
        }
        catch { return "0.0.0.0"; }
    }

    public static string ToCamelCase(this string input) =>
        System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());

    public static List<T> ToList<T>(this DataTable table) where T : new()
    {
        var list = new List<T>();
        if (table is null) return list;
        var properties = typeof(T).GetProperties();
        foreach (DataRow row in table.Rows)
        {
            T item = new();
            foreach (var prop in properties)
            {
                if (table.Columns.Contains(prop.Name) && row[prop.Name] != DBNull.Value)
                {
                    try { prop.SetValue(item, Convert.ChangeType(row[prop.Name], prop.PropertyType)); }
                    catch { }
                }
            }
            list.Add(item);
        }
        return list;
    }
}
