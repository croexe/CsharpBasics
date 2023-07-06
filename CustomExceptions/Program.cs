using System;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("Stevo");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
