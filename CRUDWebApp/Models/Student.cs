using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Students name")]
        public string Name { get; set; }
        
        public int Age { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string CodeName { get; set; }

        // just overriding the ToString() method for simplicity
        public override string ToString()
        {
        return "Firstname: " + Name + Environment.NewLine +
               "Age: " + Age + Environment.NewLine +
               "CodeName: " + CodeName + Environment.NewLine;
    }
}

  


}

