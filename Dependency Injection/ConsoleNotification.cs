using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    public class ConsoleNotification : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Username has been changed to: {user.Username}");
        }
    }
}
