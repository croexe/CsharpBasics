namespace InterfacePolymorphism;

class Program
{
    static void Main(string[] args)
    {
        var video = new Video();
        var videoEncoder = new VideoEncoder();
        videoEncoder.AddNotificationService(new SMSNotification());
        videoEncoder.AddNotificationService(new EmailNotification());
        videoEncoder.RegisterVideo(video);
    }
}