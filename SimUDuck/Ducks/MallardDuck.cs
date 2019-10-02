using SimUDuckApp.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.FlyBehavior = new FlyWithWings();
            this.QuackBehavior = new QuackSound();
        }

        public override void Display()
        {
            Console.WriteLine("It is Mallard Duck");
        }
    }
}
