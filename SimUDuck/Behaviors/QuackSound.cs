﻿using SimUDuckApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp.Behaviors
{
    public class QuackSound : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack-Quack");
        }
    }
}
