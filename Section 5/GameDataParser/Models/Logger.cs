namespace GameDataParser.Models;

public class Logger
{
    readonly string _logFilePath = "logs.txt";
    
    public Logger () : this(null) {}
    public Logger (string? path)
    {
        if (path is not null) _logFilePath = path;
    }

    public void LogException(Exception ex)
    {
        string existingLog = "";
        if (File.Exists(_logFilePath))
            existingLog = File.ReadAllText(_logFilePath);
        existingLog += FormatNewLog(ex);
        File.WriteAllText(_logFilePath, existingLog);
    }

    private static string FormatNewLog(Exception ex)
    {
        return 
        $"""
        
        [{DateTime.Now}]
        Exception message: {ex.Message}
        Stack trace: {ex.StackTrace}

        """;
    }
}