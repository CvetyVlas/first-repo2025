using System;

namespace ExponentionNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //double d = 10000000000000000000000000000000000.0;
            //Console.WriteLine(d);
            //double d2 = 20E-3;
            //Console.WriteLine(d2);

            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
