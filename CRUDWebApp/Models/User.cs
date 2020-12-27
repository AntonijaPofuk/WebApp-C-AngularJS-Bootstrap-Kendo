using CRUDWebApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebApp.Models
{
    public class User
    {
        private INotificationService _notificationService;

        public User(string firstname, INotificationService notificationService)
        {
            FirstName = firstname;
            _notificationService = notificationService;
        }

        public User()
        {
           
        }
        public int Id { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z]*$"), Required, StringLength(20)]
        public string FirstName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z]*$"), Required, StringLength(20)]
        public string LastName { get; set; }
        [RegularExpression(@"^([a - zA - Z0 - 9_\-\.]+)@([a - zA - Z0 - 9_\-\.]+)\.([a - zA - Z]{2,5})$"), Required]
        public string Email { get; set; }
        public string Address { get; set; }
        public string GetFullName()
        {
            return $"{this.LastName}, {this.FirstName}";
        }

        public void ChangeFirstName(string newFirstName)
        {
            FirstName = newFirstName;
            _notificationService.NotifyFirstNameChange(this);
        }

    }
}
