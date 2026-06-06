using SupermarketWeb.Data.Models;

namespace SupermarketWeb.Data.Services;

public class BillService
{
    public List<BillTbl> GetAll(string? search = null, DateTime? from = null, DateTime? to = null)
    {
        var conditions = new List<string>();
        if (!string.IsNullOrWhiteSpace(search))
            conditions.Add($"(SellerName LIKE '%{search.Replace("'", "''")}%' OR Comments LIKE '%{search.Replace("'", "''")}%')");
        if (from.HasValue)
            conditions.Add($"Date >= '{from.Value:yyyy-MM-dd}'");
        if (to.HasValue)
            conditions.Add($"Date <= '{to.Value:yyyy-MM-dd} 23:59:59'");

        string where = conditions.Count > 0 ? string.Join(" AND ", conditions) : "";
        return DataModel.Select<BillTbl>(where: where, sort: "Date DESC");
    }

    public BillTbl? GetById(int id) =>
        DataModel.Select<BillTbl>(where: $"BillId = {id}").FirstOrDefault();

    public int? Create(BillTbl bill)
    {
        bill.Date = DateTime.Now;
        return bill.Create();
    }

    public int? Update(BillTbl bill) => bill.Update();

    public int? Delete(BillTbl bill) => bill.Delete();

    public decimal TotalRevenue()
    {
        var result = DataContext.Instance.ExecScalar("SELECT ISNULL(SUM(TotAmt), 0) FROM BillTbl");
        return Utils.GetDecimal(result, 0);
    }

    public int TotalBills() =>
        Utils.GetInt(DataContext.Instance.ExecScalar("SELECT COUNT(*) FROM BillTbl"), 0);

    public decimal TodayRevenue()
    {
        string today = $"'{DateTime.Today:yyyy-MM-dd}'";
        var result = DataContext.Instance.ExecScalar($"SELECT ISNULL(SUM(TotAmt), 0) FROM BillTbl WHERE CAST(Date AS DATE) = {today}");
        return Utils.GetDecimal(result, 0);
    }

    public List<(string Month, decimal Total)> MonthlySummary(int year)
    {
        string sql = $@"SELECT MONTH(Date) AS Mo, ISNULL(SUM(TotAmt),0) AS Tot
                        FROM BillTbl WHERE YEAR(Date) = {year}
                        GROUP BY MONTH(Date) ORDER BY Mo";
        var dt = DataContext.Instance.SelectDataTable(sql);
        var list = new List<(string, decimal)>();
        if (dt is null) return list;
        foreach (System.Data.DataRow row in dt.Rows)
        {
            int month = Utils.GetInt(row["Mo"], 0);
            decimal total = Utils.GetDecimal(row["Tot"], 0);
            list.Add((new DateTime(year, month, 1).ToString("MMM"), total));
        }
        return list;
    }
}
