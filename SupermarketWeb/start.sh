#!/bin/bash
# ──────────────────────────────────────────────────────────
# Supermarket Manager — Start Script
# ──────────────────────────────────────────────────────────

export DOTNET_ROOT="/opt/homebrew/opt/dotnet/libexec"
export PATH="$DOTNET_ROOT:$PATH"

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

echo ""
echo "🛒  Supermarket Manager"
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"

# ── 1. Start SQL Server ────────────────────────────────────
if ! docker ps --format '{{.Names}}' 2>/dev/null | grep -q "supermarket-sqlserver"; then
    echo "🐳  Εκκίνηση SQL Server..."
    cd "$SCRIPT_DIR"
    docker compose up -d 2>/dev/null || {
        echo "❌  Το Docker Desktop δεν τρέχει. Άνοιξέ το και δοκίμασε ξανά."
        exit 1
    }
    echo "⏳  Αναμονή για SQL Server (15 δευτερόλεπτα)..."
    sleep 15
    docker exec -i supermarket-sqlserver /opt/mssql-tools18/bin/sqlcmd \
        -S localhost -U sa -P 'Smarket@2024!' -C \
        -i "$SCRIPT_DIR/init-db.sql" > /dev/null 2>&1 && echo "✓   Βάση δεδομένων έτοιμη" || true
else
    echo "✓   SQL Server ήδη τρέχει"
fi

# ── 2. Start web app ───────────────────────────────────────
echo ""
echo "🚀  Εκκίνηση εφαρμογής..."
echo "🌐  URL: http://localhost:5000"
echo "🔑  Login: admin / admin123"
echo ""
echo "📋  Logs (Ctrl+C για διακοπή):"
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"

cd "$SCRIPT_DIR"
dotnet run --project SupermarketWeb/SupermarketWeb.csproj \
           --urls "http://localhost:5000" \
           --no-build 2>&1

echo ""
echo "⏹️  Εφαρμογή σταμάτησε."
