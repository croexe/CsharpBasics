using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            UsePoints();

            int number;
            var result = int.TryParse("abc", out number);

            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed!");
            }
        }

        static void UsePoints() {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine(point.X + " " + point.Y);

                point.Move(100, 500);
                Console.WriteLine(point.X + " " + point.Y);

                var zbroj = Point.Calculate(10, 1, 2, 4, 6, 5, 3, 2);



                for (int i = 0; i < zbroj.Length; i++)
                {
                    Console.WriteLine(zbroj[i]);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
