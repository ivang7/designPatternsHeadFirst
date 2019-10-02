using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp.Ducks
{
    public abstract class Duck
    {
        public string DuckType => this.GetType().Name;

        public virtual void Quack()
        {
            Console.WriteLine("Quack-Quack");
        }

        public virtual void Swim()
        {
            Console.WriteLine(DuckType + " is swimming");
        }

        public virtual void Fly()
        {
            Console.WriteLine(DuckType + " is flying");
        }

        public abstract void Display();
    }
}
