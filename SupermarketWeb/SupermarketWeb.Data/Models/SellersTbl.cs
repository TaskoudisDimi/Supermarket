namespace SupermarketWeb.Data.Models;

[TableName("SellersTbl")]
public class SellersTbl
{
    [PrimaryKey]
    public int SellerId { get; set; }

    [FieldSize(200)]
    public string SellerUserName { get; set; } = "";

    [Encrypted]
    [FieldSize(200)]
    public string SellerPass { get; set; } = "";

    [FieldSize(200)]
    public string SellerName { get; set; } = "";

    public int SellerAge { get; set; }
    public long SellerPhone { get; set; }
    public DateTime Date { get; set; }

    [FieldSize(500)]
    public string Address { get; set; } = "";

    public bool Active { get; set; }

    [Image]
    public byte[]? Image { get; set; }
}
