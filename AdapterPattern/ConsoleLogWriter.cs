using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class ConsoleLogWriter : ILogWriter
    {
        private ConsoleWriter consoleWriter = new ConsoleWriter();
        public void Out(string text)
        {
            consoleWriter.WriteConsole(text);
        }
    }
}
