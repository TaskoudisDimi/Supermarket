using SupermarketWeb.Data.Models;

namespace SupermarketWeb.Data.Services;

public class CategoryService
{
    public List<CategoryTbl> GetAll(string? search = null)
    {
        string where = "";
        if (!string.IsNullOrWhiteSpace(search))
            where = $"CatName LIKE '%{search.Replace("'", "''")}%'";
        return DataModel.Select<CategoryTbl>(where: where, sort: "CatName");
    }

    public CategoryTbl? GetById(int id) =>
        DataModel.Select<CategoryTbl>(where: $"CatId = {id}").FirstOrDefault();

    public int? Create(CategoryTbl category)
    {
        category.Date = DateTime.Now;
        return category.Create();
    }

    public int? Update(CategoryTbl category) => category.Update();

    public int? Delete(CategoryTbl category) => category.Delete();

    public int TotalCategories() =>
        Utils.GetInt(DataContext.Instance.ExecScalar("SELECT COUNT(*) FROM CategoryTbl"), 0);
}
