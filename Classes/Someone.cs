using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Someone
    {
        public string Name { get; set; }
        public string Feel { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }

        public static Someone Create(string name, string feel, int age, string occupation)
        {
            var someone = new Someone();
            someone.Name = name;
            someone.Feel = feel;
            someone.Age = age;
            someone.Occupation = occupation;

            return someone;
        }

    }
}