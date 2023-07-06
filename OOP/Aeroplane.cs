using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Aeroplane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Aeroplane is Flying");
        }
    }
}