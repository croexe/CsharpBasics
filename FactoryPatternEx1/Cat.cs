using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meuw Meuw");
        }
    }
}
