using System;
using System.Collections.Generic;
using System.Text;

namespace EventsWithEventArgs
{
    public class TextService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending SMS!    " + e.Video.Title);
        }
    }
}
