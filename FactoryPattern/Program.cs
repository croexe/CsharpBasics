using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = AnimalFactory.CreateAnimal(AnimalFactory.DOG);
            animal.Speak();
            animal.Eat();
        }
    }
}
