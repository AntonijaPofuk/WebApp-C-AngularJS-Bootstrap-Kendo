using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebApp.DesignPatterns
{

    public interface IPlant
    {
        void Eat();
    }
    public class Leaf : IPlant
    {
        public bool IsEaten { get; set; } = false;
        public void Eat()
        {
            IsEaten = true;
            Console.WriteLine("Leaf is eaten!");
        }
    }

    public class Branch : IPlant
    {
        private readonly IList<IPlant> leafs;
        public Branch(IList<IPlant> _leafs)
        {
            leafs = _leafs;
        }
        public void Eat()
        {
            foreach (var leaf in leafs)
            {
                leaf.Eat();
            }

        }
    }
}
