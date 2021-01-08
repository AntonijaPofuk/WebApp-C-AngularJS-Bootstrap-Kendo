using AutoMapper;
using CRUDWebApp.DesignPatterns;
using CRUDWebApp.DesignPatterns.Decorator;
using CRUDWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using static CRUDWebApp.Controllers.Builder;
using static CRUDWebApp.Controllers.Prototype;

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
            // Builder Design Pattern Demo
            //var vehicleCreator = new VehicleCreator(new HeroBuilder());
            //vehicleCreator.CreateVehicle();
            //var vehicle = vehicleCreator.GetVehicle();
            //vehicle.ShowInfo();
            //Console.WriteLine("---------------------------------------------");
            //vehicleCreator = new VehicleCreator(new HondaBuilder());
            //vehicleCreator.CreateVehicle();
            //vehicle = vehicleCreator.GetVehicle();
            //vehicle.ShowInfo();


            //Prototype
            Developer dev = new Developer();
            dev.Name = "Ann";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";
            Developer devCopy = (Developer) dev.Clone();
            devCopy.Name = "Anna"; //Not mention Role and PreferredLanguage, it will copy above
            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());
            Typist typist = new Typist();
            typist.Name = "Beta";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;
            Typist typistCopy = (Typist) typist.Clone();
            typistCopy.Name = "Betty";
            typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above
            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());

            //Decorator
            IPizza pizza = new Pizza();
            IPizza cheeseDecorator = new CheeseDecorator(pizza);
            IPizza tomatoDecorator = new TomatoDecorator(cheeseDecorator);
            IPizza onionDecorator = new OnionDecorator(tomatoDecorator);
            Console.WriteLine(tomatoDecorator.getPizzaType());


            //Adapter
            var bagOfPeelableFruit = new List<IPeelable>();
            bagOfPeelableFruit.Add(new Orange());
            bagOfPeelableFruit.Add(new Banana());
            bagOfPeelableFruit.Add(new SkinnableTOPelableAdapter(new Apple()));
            bagOfPeelableFruit.Add(new SkinnableTOPelableAdapter(new Pear()));
            foreach (var fruit in bagOfPeelableFruit){
                fruit.Peel();
            }

            //Composite
            var plants = new List<IPlant>();
            var branchI = new Branch(new List<IPlant>() { new Leaf(), new Leaf() });
            var branchII = new Branch(new List<IPlant>() { new Leaf(), new Leaf(), new Leaf(), new Leaf() });
         
            plants.Add(new Branch(
                new List<IPlant>()
                    { branchI, branchII }
            ));   //branch with two branches
            plants.Add(new Leaf());  //one leaf            
            plants.Add(new Branch(new List<IPlant>() { new Leaf(), new Leaf(), new Leaf(), new Leaf(), new Leaf() })); //one branch with leafs
            plants.Add(new Leaf());  //one leaf
            foreach (IPlant plant in plants)
            {
                plant.Eat();
            }

            //Proxy
            var secureNestProxy = new SecureNestProxy(new RealNest());
            secureNestProxy.Access("Stegosaurus");
            secureNestProxy.Access("TRex");


            //Iterator
            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");
            Console.WriteLine("Straight traversal:");
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("\nReverse traversal:");
            collection.ReverseDirection();
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            //State
            Steak steak = new Steak("T-Bone");
            steak.AddTemp(120);
            steak.AddTemp(15);
            steak.AddTemp(15);
            steak.RemoveTemp(10); 
            steak.RemoveTemp(15);
            steak.AddTemp(20);
            steak.AddTemp(20);
            steak.AddTemp(20);

            //Command
            Console.WriteLine("Enter Commands (ON/OFF) : ");
            string cmd = "ON"; //Console.ReadLine();
            Light lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);
            Switch s = new Switch();
            if (cmd == "ON")
            {
                s.StoreAndExecute(switchUp);
            }
            else if (cmd == "OFF")
            {
                s.StoreAndExecute(switchDown);
            }
            else
            {
                Console.WriteLine("Command \"ON\" or \"OFF\" is required.");
            }

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

