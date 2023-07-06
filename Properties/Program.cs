using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime(1988, 8, 8);
            Console.WriteLine(person.Age);
        }
    }
}
