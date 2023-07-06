using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    public class User 
    {
        private INotificationService _notificationService;
        public User(string username, INotificationService notificationService)
        {
            Username = username;
            _notificationService = notificationService;
        }
        public string Username { get; private set; }

        public void ChangeUsername(string newUsername)
        {
            Username = newUsername;
            _notificationService.NotifyUsernameChanged(this);
        }

    }
}
