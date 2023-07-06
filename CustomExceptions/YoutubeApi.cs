using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptions
{
   public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try 
            {
                throw new Exception("Some low level youtube exception.");
            }
            catch(Exception ex) {
                throw new YoutubeException("Couldnt fetch videos from youtube", ex);
            }

            return new List<Video>();
        }
    }
}