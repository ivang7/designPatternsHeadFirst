using SimUDuckApp.Behaviors;
using System;

namespace SimUDuckApp.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.FlyBehavior = new FlyNoWay();
            this.QuackBehavior = new SqueakSound();
        }

        public override void Display()
        {
            Console.WriteLine("It is Rubber Duck");
        }
    }
}
