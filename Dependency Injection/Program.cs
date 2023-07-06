using System;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleNotificationService = new ConsoleNotification();
            var user = new User("Stevi", consoleNotificationService);
            Console.WriteLine(user.Username);

            user.ChangeUsername("Milojko");

            var webNotificationService = new WebNotification();
            var webUser = new User("Igor", webNotificationService);
            webUser.ChangeUsername("Vladimir Putin");
        }
    }
}
