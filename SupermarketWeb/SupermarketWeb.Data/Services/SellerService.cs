using SupermarketWeb.Data.Models;

namespace SupermarketWeb.Data.Services;

public class SellerService
{
    public List<SellersTbl> GetAll(string? search = null)
    {
        string where = "";
        if (!string.IsNullOrWhiteSpace(search))
            where = $"SellerName LIKE '%{search.Replace("'", "''")}%' OR SellerUserName LIKE '%{search.Replace("'", "''")}%'";
        return DataModel.Select<SellersTbl>(
            fields: ["SellerId", "SellerUserName", "SellerName", "SellerAge", "SellerPhone", "Date", "Address", "Active"],
            where: where, sort: "SellerName");
    }

    public SellersTbl? GetById(int id) =>
        DataModel.Select<SellersTbl>(
            fields: ["SellerId", "SellerUserName", "SellerName", "SellerAge", "SellerPhone", "Date", "Address", "Active"],
            where: $"SellerId = {id}").FirstOrDefault();

    public int? Create(SellersTbl seller)
    {
        seller.Date = DateTime.Now;
        return seller.Create();
    }

    public int? Update(SellersTbl seller) =>
        seller.Update(["SellerUserName", "SellerName", "SellerAge", "SellerPhone", "Address", "Active"]);

    public int? ChangePassword(int sellerId, string newPassword)
    {
        string hash = Utils.HashPassword(newPassword);
        string sql = $"UPDATE [SellersTbl] SET SellerPass = '{hash.Replace("'", "''")}' WHERE SellerId = {sellerId}";
        return DataContext.Instance.ExecuteNQ(sql) > 0 ? 1 : -1;
    }

    public int? Delete(SellersTbl seller) => seller.Delete();

    public bool UsernameExists(string username, int? excludeId = null)
    {
        string where = excludeId.HasValue
            ? $"SellerUserName = '{username.Replace("'", "''")}' AND SellerId <> {excludeId}"
            : $"SellerUserName = '{username.Replace("'", "''")}' ";
        return DataModel.Select<SellersTbl>(where: where).Count > 0;
    }

    public int TotalSellers() =>
        Utils.GetInt(DataContext.Instance.ExecScalar("SELECT COUNT(*) FROM SellersTbl WHERE Active = 1"), 0);
}
