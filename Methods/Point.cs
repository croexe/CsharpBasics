using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {

            if(newLocation == null)
            {
                throw new ArgumentNullException("Trebas staviti novu lokaciju!");
            }

            Move(newLocation.X, newLocation.Y);

            //  this.X = newLocation.X;
          
            // this.Y = newLocation.Y;
        }

        public static int[] Calculate(int multiplayer, params int[] numbers )
        {
            var current = new int[numbers.Length];
            var result = 0;
           for(int i = 0; i < numbers.Length; i++)
            {
                current[i] += multiplayer * numbers[i];
                result += numbers[i];
            }
            Console.WriteLine(result);
            return current;
        }
    }
}
