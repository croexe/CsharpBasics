using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogWriter consoleLogWriter = new ConsoleLogWriter();
            Logger logger = new Logger(consoleLogWriter);
            logger.Write("Hello there");
        }
    }
}
