using SimUDuckApp.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp.Ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            this.FlyBehavior = new FlyWithWings();
            this.QuackBehavior = new QuackSound();
        }

        public override void Display()
        {
            Console.WriteLine("It is Redhead Duck");
        }
    }
}
