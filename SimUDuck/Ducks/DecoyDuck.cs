using System;
namespace SimUDuckApp.Ducks
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("It is Decoy Duck");
        }

        public override void Quack()
        {
        }

        public override void Fly()
        {
        }
    }
}
