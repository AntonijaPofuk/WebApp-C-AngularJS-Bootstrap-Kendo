using AutoMapper;
using CRUDWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CRUDWebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            // AutoMapper


            var student1 = new Student
            {
                Name = "Kunal",
                Age = 12
            };
            var mapper = new MapperConfiguration(mapper => {
                mapper.CreateMap<Student, Employee>();
            });

            //employee1 = Mapper.Map<Student, Employee>(student1);

            Console.WriteLine("Automapeer is done!");

            Console.WriteLine(student1.GetType());
                                 
            bool b1 = student1.GetType() == typeof(Student); // true
            bool b2 = student1.GetType() == typeof(Employee); // false!

            Console.WriteLine(b1.ToString() , b2.ToString());

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
