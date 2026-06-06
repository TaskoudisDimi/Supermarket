namespace SupermarketWeb.Data.Models;

[TableName("CategoryTbl")]
public class CategoryTbl
{
    [PrimaryKey]
    public int CatId { get; set; }

    [FieldSize(200)]
    public string CatName { get; set; } = "";

    [FieldSize(500)]
    public string CatDesc { get; set; } = "";

    public DateTime Date { get; set; }
}
