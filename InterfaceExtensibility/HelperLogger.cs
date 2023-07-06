namespace InterfaceExtensibility;

internal static class HelperLogger
{
    public static void Log(string message, string logType)
    {
        Console.WriteLine(logType + ": " + message);
    }
}