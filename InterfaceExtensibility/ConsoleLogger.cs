namespace InterfaceExtensibility;

internal class ConsoleLogger : ILogger
{
    public void LogError(string message)
    {
        Log(message, "Error");
    }

    public void LogInfo(string message)
    {
        Log(message, "Info");
    }

    private void Log(string message, string logType)
    {
        Console.WriteLine(logType + ": " + message);
    }
}