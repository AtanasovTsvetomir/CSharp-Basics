﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SafePasswordGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPassword = int.Parse(Console.ReadLine());

            char A = (char)35;
            char B = (char)64;

            int generatedPassword = 0;

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    if (maxPassword == generatedPassword)
                    {
                        return;
                    }
                    if (A > 55)
                    {
                        A = (char)35;
                    }
                    if (B > 96)
                    {
                        B = (char)64;
                    }
                    Console.Write($"{A}{B}{i}{j}{B}{A}|");

                    A++;
                    B++;
                    generatedPassword++;
                }
            }
        }
    }
}

 

