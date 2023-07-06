namespace InterfacePolymorphismConsole;

internal class EmailNotification : INotificationService
{
    public void Send()
    {
        Console.WriteLine("Sending Email.");
    }
}