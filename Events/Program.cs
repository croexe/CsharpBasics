using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Spider Man" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
