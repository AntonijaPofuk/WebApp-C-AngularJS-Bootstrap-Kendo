using AutoMapper;
using CRUDWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using static CRUDWebApp.Controllers.Builder;

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

            /// Builder Design Pattern Demo
            var vehicleCreator = new VehicleCreator(new HeroBuilder());
            vehicleCreator.CreateVehicle();
            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");

            vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.CreateVehicle();
            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();
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

