using System;

namespace FactoryPatternEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = AnimalFactory.CreateAnimal(AnimalFactory.CAT);
            animal.Speak();

            var businessObject = ObjectFactory.Create();
            businessObject.ConcreteLogic();
            businessObject.SmartWorking();
            
            var businessLogic = ObjectFactory.CreateBusinessLogic("Shop");
            businessLogic.SmartWorking();
            
            
        }
    }
}
