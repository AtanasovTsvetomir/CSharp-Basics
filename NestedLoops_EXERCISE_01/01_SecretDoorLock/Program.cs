﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SecretDoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            for (int i = 2; i <= firstNum; i++)
            {
                for (int j = 2; j <= secondNum; j++)
                {
                    for (int k = 2; k <= thirdNum; k++)
                    {
                        if (i % 2 != 0)
                        {
                            continue;
                        }
                        if (k % 2 != 0)
                        {
                            continue;
                        }
                        if (j != 2 && j != 3 && j != 5 && j != 7)
                        {
                            continue;
                        }
                        Console.WriteLine($"{i} {j} {k}");
                    }
                }
            }
        }
    }
}
