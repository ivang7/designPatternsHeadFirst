using SimUDuckApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp.Behaviors
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
