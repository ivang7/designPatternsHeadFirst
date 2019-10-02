using System;
using System.Collections.Generic;

namespace SimUDuckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ducks = new List<Duck>();
            
            ducks.Add(new MallardDuck());
            ducks.Add(new RedheadDuck());
            ducks.Add(new DecoyDuck());
            ducks.Add(new MallardDuck());
            ducks.Add(new RubberDuck());

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Quack();
                duck.Swim();
                duck.Quack();
                duck.Fly();

                Console.WriteLine();
            }
        }
    }
}
