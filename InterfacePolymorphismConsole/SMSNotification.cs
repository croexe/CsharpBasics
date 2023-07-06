namespace InterfacePolymorphismConsole;

public class SMSNotification : INotificationService
{
    public void Send()
    {
        Console.WriteLine("Sending SMS.");
    }
}