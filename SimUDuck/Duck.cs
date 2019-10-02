using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp
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

        public abstract void Display();
    }
}
