using SupermarketWeb.Data.Models;

namespace SupermarketWeb.Data.Services;

public class AuthService
{
    public enum Role { None, Admin, SuperAdmin, Seller }

    public Admins? CurrentAdmin { get; private set; }
    public SellersTbl? CurrentSeller { get; private set; }
    public Role CurrentRole { get; private set; } = Role.None;
    public bool IsAuthenticated => CurrentRole != Role.None;

    public bool LoginAdmin(string username, string password)
    {
        var admins = DataModel.Select<Admins>(where: $"UserName = '{username.Replace("'", "''")}' AND Active = 1");
        var admin = admins.FirstOrDefault();
        if (admin is null) return false;
        if (!Utils.VerifyPassword(password, admin.Password)) return false;
        CurrentAdmin = admin;
        CurrentRole = admin.isSuperAdmin ? Role.SuperAdmin : Role.Admin;
        return true;
    }

    public bool LoginSeller(string username, string password)
    {
        var sellers = DataModel.Select<SellersTbl>(where: $"SellerUserName = '{username.Replace("'", "''")}' AND Active = 1");
        var seller = sellers.FirstOrDefault();
        if (seller is null) return false;
        if (!Utils.VerifyPassword(password, seller.SellerPass)) return false;
        CurrentSeller = seller;
        CurrentRole = Role.Seller;
        return true;
    }

    public void Logout()
    {
        CurrentAdmin = null;
        CurrentSeller = null;
        CurrentRole = Role.None;
    }

    public string DisplayName => CurrentRole switch
    {
        Role.Admin or Role.SuperAdmin => CurrentAdmin?.UserName ?? "",
        Role.Seller => CurrentSeller?.SellerName ?? "",
        _ => ""
    };
}
