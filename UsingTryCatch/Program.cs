using System;
using System.IO;

namespace UsingTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip")) ;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
