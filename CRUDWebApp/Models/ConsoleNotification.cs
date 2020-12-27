using System;

namespace CRUDWebApp.Models
{
    internal class ConsoleNotification
    {
        public void NotifyFirstNameChange(User user)
        {
            Console.WriteLine($"Username has been changed to:  { user.FirstName}");
        }

    }
}
