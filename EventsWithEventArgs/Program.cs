using System;

namespace EventsWithEventArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Superman" };
            var videoEncoder = new VideoEncoder();
            var emailService = new MailService();
            var textService = new TextService();

            videoEncoder.VideoEncoded += emailService.SendEmail;
            videoEncoder.VideoEncoded += textService.OnVideoEncoded;

            videoEncoder.Encode(video);


        }
    }
}
