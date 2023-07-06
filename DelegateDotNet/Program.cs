using System;

namespace DelegateDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var filter = new PhotoFilters();
            var process = new PhotoProcess();

            Action<Photo> filterHandler = filter.ApplyBrightness;

            process.Process("picture.jpeg", filterHandler);
        }
    }
}
