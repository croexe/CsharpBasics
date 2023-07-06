namespace InterfacePolymorphism;

public class SMSNotification : INotificationService
{
    public void Send()
    {
        Console.WriteLine("Sending SMS.");
    }
}