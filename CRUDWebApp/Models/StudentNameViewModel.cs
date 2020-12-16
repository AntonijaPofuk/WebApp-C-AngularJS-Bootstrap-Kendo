using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebApp.Models
{
    public class StudentNameViewModel
    {
        public List<Student> Students { get; set; }
        public SelectList Names { get; set; }
        public string StudentName { get; set; }
        public string SearchString { get; set; }
    }
}
