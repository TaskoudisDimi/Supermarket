using Microsoft.Data.SqlClient;
using SupermarketWeb.Data.Models;

namespace SupermarketWeb.Data.Services;

public class ProductService
{
    public List<ProductTbl> GetAll(string? search = null)
    {
        string where = "";
        if (!string.IsNullOrWhiteSpace(search))
            where = $"ProdName LIKE '%{search.Replace("'", "''")}%' OR ProdCat LIKE '%{search.Replace("'", "''")}%'";
        return DataModel.Select<ProductTbl>(where: where, sort: "ProdName");
    }

    public ProductTbl? GetById(int id) =>
        DataModel.Select<ProductTbl>(where: $"ProdId = {id}").FirstOrDefault();

    public List<ProductTbl> GetByCategory(int catId) =>
        DataModel.Select<ProductTbl>(where: $"ProdCatID = {catId}", sort: "ProdName");

    public int? Create(ProductTbl product)
    {
        product.Date = DateTime.Now;
        return product.Create();
    }

    public int? Update(ProductTbl product) => product.Update();

    public int? Delete(ProductTbl product) => product.Delete();

    public bool UpdateStock(int productId, int newQty)
    {
        string sql = $"UPDATE [ProductTbl] SET ProdQty = {newQty} WHERE ProdId = {productId}";
        return DataContext.Instance.ExecuteNQ(sql) > 0;
    }

    public int TotalProducts() =>
        Utils.GetInt(DataContext.Instance.ExecScalar("SELECT COUNT(*) FROM ProductTbl"), 0);

    public int LowStockCount(int threshold = 5) =>
        Utils.GetInt(DataContext.Instance.ExecScalar($"SELECT COUNT(*) FROM ProductTbl WHERE ProdQty <= {threshold}"), 0);
}
