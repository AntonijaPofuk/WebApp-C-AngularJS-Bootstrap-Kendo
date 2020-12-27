using CRUDWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebApp.Controllers
{
    public class HomeController : Controller
    {
         public IActionResult Index()
        {
            ReadUserDepInj();         
            return View();
        }
        static void ReadUserDepInj()
        {
            var user1 = new User("Tim");
            user1.ChangeFirstName("Fred");
            Console.WriteLine($"New username is:  { user1.FirstName}");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
