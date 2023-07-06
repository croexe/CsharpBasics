using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public static Person Create(string name, string surname)
        {
            var person = new Person();
            person.Name = name;
            person.Surname = surname;
            return person;
        }

        public static Person Proslijedi(string words)
        {
            var fullName = new string[2];
            fullName = words.Split(' ', 2);
            var person = Create(fullName[0], fullName[1]);
            return person;
        }

        public void Introduce(Someone someone, Person person)
        {
            Console.WriteLine("Hi {0}, I am {1}. I would like to know" +
                "what is your occupation? I am {2}. I am am {3} years old," +
                "and I feel so {4} today. You ? I am {5} years old." +
                "I have famous surname: {6}", someone.Name, person.Name,
                someone.Occupation, someone.Age, someone.Feel, person.Age, person.Surname);
        }
    }
}
