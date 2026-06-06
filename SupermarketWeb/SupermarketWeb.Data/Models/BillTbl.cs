namespace SupermarketWeb.Data.Models;

[TableName("BillTbl")]
public class BillTbl
{
    [PrimaryKey]
    public int BillId { get; set; }

    [FieldSize(500)]
    public string Comments { get; set; } = "";

    [FieldSize(200)]
    public string SellerName { get; set; } = "";

    public DateTime Date { get; set; }
    public decimal TotAmt { get; set; }

    [FieldSize(1000)]
    public string ProductIDs { get; set; } = "";

    [FieldSize(1000)]
    public string CategoryIDs { get; set; } = "";
}
