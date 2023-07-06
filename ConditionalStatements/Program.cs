using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var doba = GodisnjaDoba.ljeto;

            switch (doba)
            {
                case GodisnjaDoba.ljeto:
                    Console.WriteLine("Ubi vrucina!");
                    break;

                case GodisnjaDoba.jesen:
                    Console.WriteLine("Pripreme za turisticku sezonu! :)");
                    break;

                default:
                    Console.WriteLine("Inace sve po starom!");
                    break;
            }

            bool isPrepaid = false;

            var write = isPrepaid ? 12.05f : 15.39f;
            Console.WriteLine(write);
        }
    }
}
