using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Bird is Flying");        }
    }
}
