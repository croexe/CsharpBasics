using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    public class SecondConcreteBusinessObject : IBusinessLogic
    {
        public void SmartWorking()
        {
            Console.WriteLine("Second business Object");
        }

        public void SecondObjectMethodRepresentation()
        {
            Console.WriteLine("I am method form second concrete object");
        }
    }
}
