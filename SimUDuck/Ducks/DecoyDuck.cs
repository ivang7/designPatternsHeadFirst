using SimUDuckApp.Behaviors;
using System;
namespace SimUDuckApp.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            this.FlyBehavior = new FlyNoWay();
            this.QuackBehavior = new SilientSound();
        }

        public override void Display()
        {
            Console.WriteLine("It is Decoy Duck");
        }
    }
}
