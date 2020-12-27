using CRUDWebApp.Controllers;
using System;

namespace CRUDWebApp.Models
{
    internal class ConsoleNotification: INotificationService
    {

       public void NotifyFirstNameChange(User user)
        {
            Console.WriteLine($"Username has been changed to:  { user.FirstName}");
        }

    }
}
