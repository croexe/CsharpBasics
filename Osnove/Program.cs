using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Osnove
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = 1;
            var change = Increment(number);

            Console.WriteLine("number: {0}, change: {1}", number, change);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine("Person Age: " + person.Age);

            var a = 10;
            var b = a++;
            
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            string s = "1";
            int j = Convert.ToInt32(s);
            int i = int.Parse(s);
            string l = Convert.ToString(i);

            Console.WriteLine("Pretvoreno iz stringa u Int32: " + j + "\nPretvoreno iz stringa u Int32: " + i + "\nPretvoreno Int32 u string: " + l);

            var ar1 = new int[3] { 1, 2, 3};
            var ar2 = ar1;
            ar1[0] = 0;
            Console.WriteLine(string.Format("ar1[0]: {0}, ar2[0]: {1}", ar1[0], ar2[0]));


            var random = new Random();
            int passLength = 10;
            char[] buffer = new char[passLength];

            for (var k = 1;  k < passLength; k++)
            {
                buffer[i] = (char)(random.Next(97, 122));
                var password = new string(buffer);
                Console.Write(password);
            }
            Console.WriteLine();

            var datum = new DateTime(2015, 1, 1);
            var sada = DateTime.Now;
            var danas = DateTime.Today;

            var sutra = sada.AddDays(1);
            var jucer = sada.AddDays(-1);

            Console.WriteLine(datum);
            Console.WriteLine(danas);
            Console.WriteLine(sada.ToShortDateString());
            Console.WriteLine(sada.ToShortTimeString());
            Console.WriteLine(sada.ToString());

            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(3);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("SubStruct Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:05"));

            var punoIme = "Steva Med ";
            Console.WriteLine("Obicni: '{0}'", punoIme);
            Console.WriteLine("Trim: '{0}'", punoIme.Trim());
            Console.WriteLine("ToUpper: '{0}'", punoIme.Trim().ToUpper());

            var index = punoIme.IndexOf(' ');
            var ime = punoIme.Substring(0, index);
            var prezime = punoIme.Substring(index + 1);
            Console.WriteLine(ime);
            Console.WriteLine(prezime);

            var imena = punoIme.Split(' ');
            Console.WriteLine("Ime: '{0}'", imena[0]);
            Console.WriteLine("Prezime: '{0}'", imena[1]);

            punoIme.Replace("Steva", "Ilja");
            punoIme.Replace('M', 'T');
            Console.WriteLine(punoIme.Replace("Steva", "Ilja"));

            float broj = 23.95f;
            string cbroj = Convert.ToString(broj);
            string pbroj = broj.ToString();
            string pare = broj.ToString("C");
            string okruglo = broj.ToString("C0");

            string cijena = "20,05";
            float pre = float.Parse(cijena);


            Console.WriteLine(cbroj);
            Console.WriteLine(pbroj);
            Console.WriteLine(pare);
            Console.WriteLine(okruglo);
            Console.WriteLine(pre);

            var sentence = "This is some repeating of the same stuff over over over and over again :D !!!!! !!! !!!";
            var summary = StringUtility.SummerizeText(sentence, 28);
            Console.WriteLine(summary);

            var builder = new StringBuilder();

            builder.Append('-', 12)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 12)
            .Replace('-', '+')
            .Remove(0, 12)
            .Insert(0, new string('-', 12));

            Console.WriteLine(builder);
            Console.WriteLine(builder[15]);


            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed: " + reversed);

            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Unique numbers: ");
            foreach (var numb in GetUniqueNumbers(numbers))
                Console.WriteLine(numb);


           
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var num in numbers)
            {
                if (!uniques.Contains(num))
                    uniques.Add(num);
            }
            return uniques;
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var o = name.Length; o > 0; o--)
                array[name.Length - o] = name[o - 1];

            return new string(array);
            
        }

        public static int Increment(int number)
        {
          return number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
         }
    }
}
