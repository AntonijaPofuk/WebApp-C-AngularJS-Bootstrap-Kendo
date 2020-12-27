using CRUDWebApp.Models;

namespace CRUDWebApp.Controllers
{
    
    class UserServices
    {

            public INotificationService _notificationService;

            public UserServices(INotificationService notificationService)
            {
                _notificationService = notificationService;
            }
            public void ChangeFirstName(User user, string newFirstName)
            {
                user.FirstName = newFirstName;
                _notificationService.NotifyFirstNameChange(user);
            }

        }
    }


