using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1988, 8, 8));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
