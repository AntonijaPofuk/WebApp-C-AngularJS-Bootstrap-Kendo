using CRUDWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

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
            var notificationService = new ConsoleNotification();
            var user1 = new User("Tim", notificationService);
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
