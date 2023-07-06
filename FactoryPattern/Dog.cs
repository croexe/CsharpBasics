using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Dog : AbstractAnimal, IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Vau Vau");
        }
    }
}
