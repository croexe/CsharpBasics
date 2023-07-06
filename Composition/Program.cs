using System;

namespace Composition
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migration()
        {
            _logger.Log("we are migrating");
        }
    }

    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigration = new DbMigrator(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);

            dbMigration.Migration();
            installer.Install();
        }
    }
}
