using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace MethodOverridingPolymorphism
{
    public class Shape{
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

    public class Circle : Shape, ISome
    {
        public int Space { get; set; }
        public override void Draw()
        {
            var circle = new Circle();
            circle.Height = 2;
            Console.WriteLine("Drawing a Circle");
            Console.WriteLine(circle.Height);
        }

        public void ReadMe()
        {
            Console.WriteLine("Reading Circle");
        }
    }

    public abstract class Shape2
    {
        public virtual int DoSomething() { var a = 1; return a; }
    }

    public interface ISome
    {
        void ReadMe();
    }


    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle() { Height = 1, Width = 2 });
            shapes.Add(new Rectangle() { Height = 5, Width = 10 });
            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
            ISome some = new Circle();
            some.ReadMe();

            

            
            
            
            Circle circle = new Circle();
            
            
        }
    }
}
