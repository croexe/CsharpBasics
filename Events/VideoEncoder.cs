using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {

        public delegate void VideoEncodedEventHandler(object source, EventArgs e);

        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        protected void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
