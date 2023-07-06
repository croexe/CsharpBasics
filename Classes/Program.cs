using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesi svoje puno ime:");
            var words = Console.ReadLine();
             var person = Person.Proslijedi(words);
            
           // Console.WriteLine("Unesi svoje godiste:");
          //  person.Age = int.Parse(Console.ReadLine());
            var someone = Someone.Create("Ivan", "Odlicno", 32, "Developer");
            person.Introduce(someone, person);
        }
    }
}
