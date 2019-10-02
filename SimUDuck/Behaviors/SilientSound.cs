using SimUDuckApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp.Behaviors
{
    public class SilientSound : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<Silient, no sound>");
        }
    }
}
