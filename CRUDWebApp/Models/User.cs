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
        public User(string firstname)
        {
            FirstName = firstname;
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
    }
}
