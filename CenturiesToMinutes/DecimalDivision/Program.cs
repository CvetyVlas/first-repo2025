﻿using System;

namespace DecimalDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                sum += a % b;
                Console.WriteLine("Ostatyk: "+sum);
            }
            Console.WriteLine(sum);
        }
    }
}
