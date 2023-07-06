namespace InterfacePolymorphismConsole;

internal class VideoEncoder
{
    private readonly IList<INotificationService> _notificationService;

    public VideoEncoder()
    {
        _notificationService = new List<INotificationService>();
    }

    public void Encode(Video video)
    {
        foreach (var notification in _notificationService)
        {
            notification.Send();
        }
    }

    public void AddNotificationService(INotificationService notificationService)
    {
        _notificationService.Add(notificationService);
    }
}