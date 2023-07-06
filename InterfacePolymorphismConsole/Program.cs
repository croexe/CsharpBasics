// See https://aka.ms/new-console-template for more information
using InterfacePolymorphismConsole;

Console.WriteLine("Hello, World!");

var video = new Video();
var videoEncoder = new VideoEncoder();
videoEncoder.AddNotificationService(new SMSNotification());
videoEncoder.AddNotificationService(new EmailNotification());
videoEncoder.Encode(video);