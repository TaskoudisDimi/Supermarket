#!/bin/bash
export DOTNET_ROOT="/opt/homebrew/opt/dotnet/libexec"
export PATH="$DOTNET_ROOT:$PATH"

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
cd "$SCRIPT_DIR"

echo "🔨  Building Supermarket Manager..."
dotnet build SupermarketWeb/SupermarketWeb.csproj -c Release 2>&1

if [ $? -eq 0 ]; then
    echo ""
    echo "✅  Build επιτυχές! Τώρα τρέξε: ./start.sh"
else
    echo "❌  Build απέτυχε."
fi
