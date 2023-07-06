using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Cat : IAnimal
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Speak()
        {
            Console.WriteLine("Meuw Meuw");
        }
    }
}
