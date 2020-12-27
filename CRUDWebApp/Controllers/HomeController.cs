using Autofac;
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
            //Autofac
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<ProgramModule>(); //inputs all modules from one place

            var container = containerBuilder.Build();

            var userServices = container.Resolve<UserServices>();
            var notificationService = container.Resolve<INotificationService>();
            
            var user1 = new User("Tim");
            userServices.ChangeFirstName(user1, "Fred");

            return View();
        }
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
