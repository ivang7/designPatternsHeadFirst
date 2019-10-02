using SimUDuckApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp.Ducks
{
    public abstract class Duck
    {
        public FlyBehavior FlyBehavior { private get; set; }
        public QuackBehavior QuackBehavior { private get; set; }

        public string DuckType => this.GetType().Name;

        public virtual void Quack()
        {
            this.QuackBehavior.Quack();
        }

        public virtual void Swim()
        {
            Console.WriteLine(DuckType + " is swimming");
        }

        public virtual void Fly()
        {
            this.FlyBehavior.Fly();
        }

        public abstract void Display();
    }
}
