using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Vau Vau");
        }
    }
}
