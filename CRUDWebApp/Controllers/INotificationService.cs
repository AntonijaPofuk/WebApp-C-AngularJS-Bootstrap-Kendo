using CRUDWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebApp.Controllers
{
    public interface INotificationService
    {
        void NotifyFirstNameChange(User user) { }

    }
}
