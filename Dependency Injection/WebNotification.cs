using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    public class WebNotification : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Web Notification that username has been changed to: {user.Username}");
        }
    }
}
