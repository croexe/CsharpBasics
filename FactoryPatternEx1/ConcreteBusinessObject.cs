using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    public class ConcreteBusinessObject : IBusinessLogic
    {
        public ConcreteBusinessObject()
        {

        }
        public ConcreteBusinessObject(string name)
        {
            
        }

        public void SmartWorking()
        {
            Console.WriteLine("Smart Working First business Object");
        }

        public void ConcreteLogic()
        {
            Console.WriteLine("I am not method from interface, I am method form first object");
        }
    }
}
