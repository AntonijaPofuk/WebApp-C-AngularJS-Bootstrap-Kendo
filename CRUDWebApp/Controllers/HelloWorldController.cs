using AutoMapper;
using CRUDWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CRUDWebApp.Controllers
{
   public class HelloWorldController : Controller
    {


class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal Salary { get; set; }
        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        public IActionResult Index()
        {
            // AutoMapper

            // Loaded with some data
            Employee emp = new Employee();
            emp.FirstName = "Shiv";
            emp.LastName = "Koirala";
            emp.Salary = 100;
                      
            //// Create Map
            //CreateMap<Employee, Person>();
            //// initialize Mapper only once on application/service start!
            //Mapper.Initialize(cfg => {
            //    cfg.AddProfile<MyMappingProfile>();
            //});
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}

