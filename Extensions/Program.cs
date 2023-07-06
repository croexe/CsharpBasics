using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "Ovdje se ima sta za reci, svoje nedamo tude ne zelimo!!";
            var summary = post.Change(6);
            Console.WriteLine(summary);
           
        }
    }
}
