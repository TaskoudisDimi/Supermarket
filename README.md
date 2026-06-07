# 🛒 Supermarket Manager

Σύστημα διαχείρισης σούπερ μάρκετ. Αρχικά γραμμένο ως εφαρμογή **Windows Forms / .NET 4.8**, μεταφέρθηκε σε **ASP.NET Core Blazor Server (.NET 10)** για να τρέχει σε macOS, Windows και Linux.

---

## Τεχνολογίες

| Στρώμα | Τεχνολογία |
|--------|-----------|
| Frontend / UI | Blazor Server (.NET 10) |
| Backend / Logic | ASP.NET Core + C# |
| Data Access | Custom ORM με Reflection (DataModel, DataContext) |
| Βάση Δεδομένων | Microsoft SQL Server 2022 (via Docker) |
| Password Hashing | BCrypt.Net-Next |
| Excel Import/Export | EPPlus |

---

## Λειτουργίες

### Ρόλοι Χρηστών

| Ρόλος | Πρόσβαση |
|-------|----------|
| **SuperAdmin** | Πλήρης πρόσβαση + Διαχείριση βάσης δεδομένων |
| **Admin** | Προϊόντα, Κατηγορίες, Πωλητές, Παραστατικά |
| **Seller** | Εμφάνιση προϊόντων, Δημιουργία παραστατικών |

### Screens

- **Dashboard** — Live στατιστικά (προϊόντα, κατηγορίες, πωλητές, έσοδα σήμερα, χαμηλό απόθεμα)
- **Προϊόντα** — CRUD, αναζήτηση, badge χαμηλού αποθέματος (≤5)
- **Κατηγορίες** — CRUD
- **Πωλητές** — CRUD, αλλαγή κωδικού, εικόνα προφίλ
- **Παραστατικά** — Λίστα με φίλτρα ημερομηνίας, λεπτομέρειες, διαγραφή
- **Νέο Παραστατικό** — Επιλογή προϊόντων, ποσότητες, αυτόματη ενημέρωση αποθέματος
- **Βάση Δεδομένων** (SuperAdmin) — Backup, Restore, Καθαρισμός

---

## Προαπαιτούμενα

- **macOS** (10.15+) ή Windows / Linux
- [Docker Desktop](https://www.docker.com/products/docker-desktop/) — για τον SQL Server
- [Homebrew](https://brew.sh/) (μόνο macOS) — για το .NET SDK

Το .NET 10 SDK εγκαθίσταται αυτόματα από το `setup.sh` αν δεν υπάρχει.

---

## Εγκατάσταση & Εκτέλεση (macOS)

### 1. Clone του repository

```bash
git clone https://github.com/Taskoudis-Dimi/Supermarket.git
cd Supermarket
```

### 2. Εγκατάσταση .NET SDK (αν δεν υπάρχει)

```bash
brew install dotnet
```

### 3. Build της εφαρμογής

```bash
cd SupermarketWeb
./build.sh
```

### 4. Εκκίνηση (SQL Server + Blazor App)

```bash
./start.sh
```

Η εφαρμογή ανοίγει στο **http://localhost:5000**

### 5. Login

| Χρήστης | Κωδικός | Ρόλος |
|---------|---------|-------|
| `admin` | `admin123` | SuperAdmin |

---

## Scripts

| Script | Λειτουργία |
|--------|-----------|
| `./build.sh` | Κάνει compile την εφαρμογή |
| `./start.sh` | Ξεκινά SQL Server (Docker) + Blazor App |

**Για να σταματήσεις:** `Ctrl+C` στο terminal

---

## Δομή Project

```
Supermarket/
├── SupermarketWeb/              # Blazor Server (.NET 10) — τρέχει σε macOS
│   ├── SupermarketWeb/          # Web application (UI, Pages, Layout)
│   │   ├── Components/
│   │   │   ├── Layout/          # MainLayout, NavMenu, ReconnectModal
│   │   │   └── Pages/           # Login, Home, Products, Categories,
│   │   │                        # Sellers, Bills, CreateBill, DatabaseAdmin
│   │   ├── wwwroot/app.css      # Custom CSS (no Bootstrap dependency)
│   │   ├── appsettings.json     # Connection string
│   │   └── Program.cs           # App startup & DI configuration
│   ├── SupermarketWeb.Data/     # Data Layer (cross-platform)
│   │   ├── DataContext.cs       # SQL Server connection (singleton)
│   │   ├── DataModel.cs         # Generic CRUD via Reflection
│   │   ├── Attributes.cs        # [TableName], [PrimaryKey], [Encrypted]...
│   │   ├── Utils.cs             # Helpers (BCrypt, logging, type conversion)
│   │   ├── Models/              # Admins, ProductTbl, CategoryTbl,
│   │   │                        # BillTbl, SellersTbl
│   │   └── Services/            # AuthService, ProductService,
│   │                            # CategoryService, BillService, SellerService
│   ├── docker-compose.yml       # SQL Server 2022 container
│   ├── init-db.sql              # Schema + seed data
│   ├── start.sh                 # Startup script
│   └── build.sh                 # Build script
│
├── SupermarketTuto/             # Original Windows Forms app (legacy)
├── DataClass/                   # Original data layer (legacy, .NET 4.8)
├── Server/                      # TCP/UDP Server (legacy)
├── Service/                     # Windows Service (legacy)
├── CallSuperMarketAPI/          # External API client (legacy)
├── smarket.sql                  # Original SQL schema
└── backupfile.bak               # Database backup
```

---

## Ανάπτυξη (Development)

### Σύνδεση βάσης δεδομένων

Η connection string βρίσκεται στο `SupermarketWeb/SupermarketWeb/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "smarketdb": "Server=localhost,1433;Database=smarket;User ID=sa;Password=Smarket@2024!;TrustServerCertificate=True;Encrypt=False;"
  }
}
```

Για production, χρησιμοποίησε **environment variables** ή **Azure Key Vault** αντί για plaintext credentials.

### Εκτέλεση SQL Server manually

```bash
cd SupermarketWeb
docker compose up -d          # Εκκίνηση
docker compose down           # Διακοπή
docker compose logs -f        # Logs
```

### Reset βάσης δεδομένων

```bash
docker exec -i supermarket-sqlserver /opt/mssql-tools18/bin/sqlcmd \
  -S localhost -U sa -P 'Smarket@2024!' -C \
  -i SupermarketWeb/init-db.sql
```

### Hot Reload (για development)

```bash
export DOTNET_ROOT="/opt/homebrew/opt/dotnet/libexec"
export PATH="$DOTNET_ROOT:$PATH"
cd SupermarketWeb
dotnet watch --project SupermarketWeb/SupermarketWeb.csproj \
             --urls "http://localhost:5000"
```

---

## Αρχιτεκτονική Data Layer

Το `SupermarketWeb.Data` υλοποιεί ένα **mini ORM** βασισμένο σε Reflection και custom Attributes:

```csharp
// Ορισμός model
[TableName("ProductTbl")]
public class ProductTbl
{
    [PrimaryKey]   public int ProdId { get; set; }
    [FieldSize(200)] public string ProdName { get; set; }
    [Encrypted]    public string Password { get; set; }  // BCrypt hash
}

// Χρήση
var products = DataModel.Select<ProductTbl>(where: "ProdQty > 0", sort: "ProdName");
product.Create();
product.Update();
product.Delete();
```

---

## Legacy Project (Windows Only)

Ο φάκελος `SupermarketTuto/` περιέχει την αρχική εφαρμογή:
- **Platform:** Windows Forms / .NET Framework 4.8
- **Database:** SQL Server (System.Data.SqlClient)
- **Features:** Όλες οι λειτουργίες + GMap.NET χάρτης, TCP/UDP networking, Windows Service

Για να τρέξει χρειάζεται **Windows + Visual Studio 2022**.

---

## Screenshots

![Login](login.gif)
