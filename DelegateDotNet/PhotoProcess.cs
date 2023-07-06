using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDotNet
{
    public class PhotoProcess
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
