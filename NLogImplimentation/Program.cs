﻿using System;

namespace NLogImplimentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition problem \n Enter a, b values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            AddNumbers add = new AddNumbers();
            Console.WriteLine("result is" + " " + add.Sum(a,b));

        }
    }
}
