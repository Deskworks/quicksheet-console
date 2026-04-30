# QuickSheet (console)

A keyboard-driven spreadsheet TUI for the terminal. Open a CSV, edit it inline, autosave, get column sums (Σ) and row products (Π) in the status bar.

![.NET 9](https://img.shields.io/badge/.NET-9.0-purple)
![License](https://img.shields.io/badge/license-MIT-blue)

## Quick Start

```bash
git clone https://github.com/cemheren/quicksheet-console.git
cd quicksheet-console
dotnet run -c Release
# or with a CSV
dotnet run -c Release -- data.csv
```

Requires [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0).

## Features

- Edit cells directly in the terminal — full keyboard navigation.
- Autosave to `%APPDATA%/ExcelConsole/autosave.csv` (or platform equivalent).
- Live column sum (Σ) per column and row product (Π) per row in the status bar.
- CSV import / export — CSV is the only persistence format.
- Cell prefixes: paste a URL or use `r: cmd` to mark a runnable cell (the console mode itself does not execute commands, but the prefixes are preserved).

## Keyboard Shortcuts

| Shortcut | Action |
|----------|--------|
| Arrow Keys | Navigate cells |
| F2 | Edit cell in status bar |
| Enter | Open file / URL |
| Ctrl+S | Save to CSV |
| Ctrl+C / X / V | Copy / Cut / Paste |
| Shift+Arrow | Extend selection / multi-select |
| Ctrl+D | Delete row |
| Ctrl+O / Ctrl+P | Insert row |
| Ctrl+Q | Quit |

## Zero Dependencies

No NuGet packages. Build straight from source. Intentional policy to avoid supply-chain risk.

## License

MIT
