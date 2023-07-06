using System;
using System.Collections.Generic;

namespace InheritanceConstructors
{
    public interface IDrawing
    {
        void Draw();
    }
    public class Vehicle : IDrawing
    {
        private readonly string _registrationNumber;
        public string Type { get; set; }


        /*   public Vehicle()
           {
               Console.WriteLine("Vehicle is being initialized");
           }*/

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialized: {0}", registrationNumber);
        }

        public virtual void Log()
        {
            Console.WriteLine("Vehicle se logira");
        }

        public virtual void Draw()
        {
            Console.WriteLine("Crtam Vehicle");
        }
    }

    public class Car : Vehicle, IDrawing
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized: {0}", registrationNumber);
        }

        public override void Log()
        {
            Console.WriteLine("Car se logira");
        }

        public override void Draw()
        {
            Console.WriteLine("Crtam Car");
        }
    }


    public class Oblik
    {
        public virtual void Draw()
        {
            Console.WriteLine("Crtam Shape");
        }
    }

    public class Kruk : Oblik
    {
        public override void Draw()
        {
            Console.WriteLine( "Crtam krug" );
        }
    }

    public class Kocka : Oblik
    {
        public override void Draw()
        {
            Console.WriteLine("Crtam kocku");
        }
    }

    public class Crtac
    {
        public void Crtanje(List<Oblik> oblici)
        {
            foreach()
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            var car = new Car("RI-571-HR");
            car.Type = "Svemirski";
            car.Log();
            car.Draw();

            IDrawing auto = new Car("RI-571-HR");
            auto.Draw();
            


            var vehicle = new Vehicle("RI-571-HR");
            vehicle.Log();
            vehicle.Draw();



        }
    }
}
