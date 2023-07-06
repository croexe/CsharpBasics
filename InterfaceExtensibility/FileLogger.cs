namespace InterfaceExtensibility;

internal class FileLogger : ILogger
{
    private readonly string _path;

    public FileLogger(string path)
    {
        _path = path;
    }

    public void LogError(string message)
    {
        Log(message, "ERROR");
    }

    public void LogInfo(string message)
    {
        Log(message, "INFO");
    }

    private void Log(string message, string logType)
    {
        using (var sw = new StreamWriter(_path, true))
        { sw.WriteLine(logType + ": " + message); }
    }
}