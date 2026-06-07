using SupermarketWeb.Components;
using SupermarketWeb.Data;
using SupermarketWeb.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Configure DataContext with connection string from appsettings
string connStr = builder.Configuration.GetConnectionString("smarketdb")
    ?? throw new InvalidOperationException("Connection string 'smarketdb' not found.");
DataContext.Configure(connStr);

// Add services
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddHubOptions(o => o.EnableDetailedErrors = true);

// Register app services as Scoped (per Blazor circuit)
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<SellerService>();
builder.Services.AddScoped<BillService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
