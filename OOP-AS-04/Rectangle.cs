﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AS_04
{
    internal class Rectangle : IRectangl
    {
        public double area { get ; set; }

        public void DisplayShapeInfo(double area)
        {
            Console.WriteLine($"Area  of Rectangle : {area}");
        }
    }
}
