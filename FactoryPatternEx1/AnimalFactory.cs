using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    public abstract class AnimalFactory
    {
        public const int DOG = 1;
        public const int CAT = 0;

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
