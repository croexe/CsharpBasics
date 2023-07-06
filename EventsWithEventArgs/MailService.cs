using System;
using System.Collections.Generic;
using System.Text;

namespace EventsWithEventArgs
{
    public class MailService
    {
        public void SendEmail(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending Email : " + e.Video.Title);
        }
    }
}
