using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("Pict.jpeg", filterHandler);
            
            var operations = new MathOperations();
            var picker = new MathProcessor();
            int result;

            Func<int,int> pickerHandler = operations.Multiplier;
            //pickerHandler += operations.Sum;
            //pickerHandler += operations.Deducte;

            result = picker.OperationPicker(6, pickerHandler);

            Console.WriteLine(result);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply Remove red eye.");
        }
    }
}
