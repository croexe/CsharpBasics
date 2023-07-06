using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace FactoryPattern
{
    public abstract class AnimalFactory
    {
        public const int CAT = 0;
        public const int DOG = 1;
        public static IAnimal CreateAnimal(int type)
        {
            switch (type)
            {
                case CAT:
                    return new Cat();

                case DOG:
                    return new Dog();
            }
            return null;
        }
    }
}
