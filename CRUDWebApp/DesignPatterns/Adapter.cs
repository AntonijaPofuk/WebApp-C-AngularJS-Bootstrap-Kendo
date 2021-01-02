using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebApp.DesignPatterns
{
       public interface IPeelable {
        public void Peel();

    }

    public class Orange : IPeelable
    {
        public void Peel()
        {
            Console.Write("Peel a orange.");
        }
    }

    public class Banana : IPeelable
    {
        public void Peel()
        {
            Console.Write("Peel a banana.");
        }
    }

    public interface ISkinnable
    {
        void Skin();
    }

    public class Apple : ISkinnable
    {
        public void Skin()
        {
            Console.Write("Skin an apple.");
        }
    }

    public class Pear : ISkinnable
    {
        public void Skin()
        {
            Console.Write("Skin an pear.");
        }
    }

    internal class SkinnableTOPelableAdapter : IPeelable
    {
        private ISkinnable _skinable;

        public SkinnableTOPelableAdapter(ISkinnable NotSkinable)
        {
            this._skinable = NotSkinable;
        }

        public void Peel()
        {
            _skinable.Skin();
        }
    }
}

