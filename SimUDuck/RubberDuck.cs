using System;
namespace SimUDuckApp
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("It is Rubber Duck");
        }

        public override void Quack()
        {
            Console.WriteLine("Squeak-Squeak");
        }

        public override void Fly()
        {
        }
    }
}
