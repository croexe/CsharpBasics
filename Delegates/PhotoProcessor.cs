using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class PhotoProcessor
    {
       // public delegate void PhotoFilterHandler(Photo photo);
       // public void Process(string path, PhotoFilterHandler filterHandler)
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
         //   var filters = new PhotoFilters();

         //   filters.ApplyBrightness(photo);

            filterHandler(photo);

            photo.Save();
        }
    }
}