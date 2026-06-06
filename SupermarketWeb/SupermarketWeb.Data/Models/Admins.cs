namespace SupermarketWeb.Data.Models;

[TableName("Admins")]
public class Admins
{
    [PrimaryKey]
    public int Id { get; set; }

    [FieldSize(200)]
    public string UserName { get; set; } = "";

    [Encrypted]
    [FieldSize(200)]
    public string Password { get; set; } = "";

    public bool Active { get; set; }

    [NullableField(true)]
    public bool isSuperAdmin { get; set; }
}
