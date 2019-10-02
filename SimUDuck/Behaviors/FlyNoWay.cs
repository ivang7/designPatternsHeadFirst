using SimUDuckApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp.Behaviors
{
    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
