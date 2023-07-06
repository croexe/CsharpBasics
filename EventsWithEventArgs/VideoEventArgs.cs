using System;
using System.Collections.Generic;
using System.Text;

namespace EventsWithEventArgs
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
