using ExcelConsole;

public class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        string? csvPath = args.FirstOrDefault(a => !a.StartsWith("--"));
        var app = new SpreadsheetApp(csvPath);
        app.Run();
    }
}
