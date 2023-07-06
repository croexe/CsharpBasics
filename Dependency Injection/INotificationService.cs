using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    public interface INotificationService
    {
        void NotifyUsernameChanged(User user);
    }
}
