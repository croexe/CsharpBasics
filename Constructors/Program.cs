using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var kupac = new Customer();
            kupac.Id = 1;
            kupac.Name = "Steva";

            var order = new Order();
            kupac.Orders.Add(order);

            Console.WriteLine(kupac.Id + " " + kupac.Name);

            var dva = new Customer(1, "Jova");
            Console.WriteLine(dva.Id + " " + dva.Name);

            var ivan = new Customer
            {
                Id = 21,
                Name = "Ivan"
            };

            Console.WriteLine(ivan.Id + " " + ivan.Name);

        }
    }
}
