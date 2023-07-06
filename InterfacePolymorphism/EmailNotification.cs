namespace InterfacePolymorphism;

internal class EmailNotification : INotificationService
{
    public void Send()
    {
        Console.WriteLine("Sending Email.");
    }
}