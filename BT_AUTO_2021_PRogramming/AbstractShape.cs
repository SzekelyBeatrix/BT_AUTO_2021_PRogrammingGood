﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    abstract class AbstractShape : IShape
    {
        public abstract Draw();
        public abstract void Color();

        public void DoSmething()
        {
            Console.WriteLine("Shape is doing something!");
        }
    }
}
