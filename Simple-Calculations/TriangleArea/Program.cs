﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Put b :");
            double h = double.Parse(Console.ReadLine());
            double area = a * h / 2;
            Console.WriteLine(Math.Round(area,2));
        }
    }
}
