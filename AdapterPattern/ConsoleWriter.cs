using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class ConsoleWriter
    {
        public void WriteConsole(string text)
        {
            Console.WriteLine(text);
        }
    }
}
