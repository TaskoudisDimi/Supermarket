namespace SupermarketWeb.Data.Models;

[TableName("ProductTbl")]
public class ProductTbl
{
    [PrimaryKey]
    public int ProdId { get; set; }

    [FieldSize(200)]
    public string ProdName { get; set; } = "";

    public int ProdQty { get; set; }
    public decimal ProdPrice { get; set; }
    public int ProdCatID { get; set; }

    [FieldSize(200)]
    public string ProdCat { get; set; } = "";

    public DateTime Date { get; set; }
}
