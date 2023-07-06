using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace FactoryPatternEx1
{
    public static class ObjectFactory
    {
        public static ConcreteBusinessObject Create()
        {
            return new ConcreteBusinessObject();
        }

        public static IBusinessLogic CreateBusinessLogic(string name) 
        {
            

            if (name == "Shop")
            {
                return new ConcreteBusinessObject();
            } else
            {
                return new SecondConcreteBusinessObject();
            } 
        }
    }
}
