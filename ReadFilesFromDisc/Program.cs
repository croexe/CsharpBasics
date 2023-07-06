using System;
using System.IO;

namespace ReadFilesFromDisc
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Irinej\Downloads\Tekst.txt";
            var pathCreate = @"C:\Users\Irinej\Downloads\KopijaKlon.txt";
          //  File.Copy("C:\\Users\\Irinej\\Downloads\\Sara.jpeg", @"C:\Users\Irinej\Downloads\SaraCopy5.jpeg", true);
          //  var content = File.ReadAllText(path);
          //  File.WriteAllText(pathCreate, content);

            Directory.CreateDirectory(@"C:\Users\Irinej\Downloads\DirectoryBezVeze");
            var photos = Directory.GetFiles(@"C:\Users\Irinej\Downloads", "*.jpeg", SearchOption.AllDirectories);
          //  foreach (var photo in photos)
           //     Console.WriteLine(photo);

            var directories = Directory.GetDirectories(@"C:\Users\Irinej\Downloads", "*.*", SearchOption.AllDirectories);
           // foreach (var directory in directories)
             //   Console.WriteLine(directory);

            var indexOfDot = path.IndexOf('.');
            var extension = path.Substring(indexOfDot);
            Console.WriteLine(extension);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Get Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}
