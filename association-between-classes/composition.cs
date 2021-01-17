using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }

    public class Logger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }
    }

    public class DbMigrator
    {
        private readonly Logger _logger;    // The class whose properties we need is declared as a private field.

        public DbMigrator(Logger logger)    // By doing this, we're defining a relationship between those classes.
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating..."); // We can access the Logger Class methods this way.
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
            _logger.Log("We are installing...");
        }
    }
}
