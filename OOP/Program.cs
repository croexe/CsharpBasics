using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();

            var cat = new Cat();
            cat.Name = "Stevo";
            dog.Name = "Rufy";

            var animals = new List<Animal>();
            animals.Add(dog);
            animals.Add(cat);

            foreach(var animal in animals)
            {
                animal.Bark();
            }
            

            //polimorfizam u RunTime zna prepoznati vrstu objekta i sa istim codom cemo dobiti razliciti rezultat.
            //Referenca objekta ISTA = Vrsta objekta() Razlicita => Polimorfizam npr: ista referenca poziva razlicite objekte
            //Primjer preko Nasljedivanja
            
            //Animal animal = new Cat();
            

            //Primjer Polimorfizma preko Interfacea
            //IFlyable flyable = new Bird();
            IFlyable flyable = new Aeroplane();
            flyable.Fly();
        }
    }
}
