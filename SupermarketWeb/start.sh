#!/bin/bash
# ──────────────────────────────────────────────────────────
# Supermarket Manager — Start Script
# ──────────────────────────────────────────────────────────

set -e

export DOTNET_ROOT="/opt/homebrew/opt/dotnet/libexec"
export PATH="$DOTNET_ROOT:$PATH"

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

echo "🛒  Supermarket Manager"
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"

# 1. Start SQL Server if not running
if ! docker ps --format '{{.Names}}' | grep -q "supermarket-sqlserver"; then
    echo "🐳  Starting SQL Server..."
    cd "$SCRIPT_DIR"
    docker compose up -d
    echo "⏳  Waiting for SQL Server to be ready..."
    sleep 15
    # Initialize DB if needed
    docker exec -i supermarket-sqlserver /opt/mssql-tools18/bin/sqlcmd \
        -S localhost -U sa -P 'Smarket@2024!' -C \
        -i /dev/stdin < "$SCRIPT_DIR/init-db.sql" 2>&1 | grep -E "(rows affected|successfully|error)" || true
else
    echo "✓   SQL Server already running"
fi

# 2. Start web application
echo "🚀  Starting Blazor Server app..."
echo "📱  Open http://localhost:5000 in your browser"
echo ""
echo "🔑  Default login:  admin / admin123  (SuperAdmin)"
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
echo ""

cd "$SCRIPT_DIR"
dotnet run --project SupermarketWeb/SupermarketWeb.csproj --urls "http://localhost:5000"
