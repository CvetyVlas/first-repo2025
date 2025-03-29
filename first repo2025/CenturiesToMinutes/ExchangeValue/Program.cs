using System;

namespace ExchangeValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var c = 0;

            Console.WriteLine("Before");
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= "+b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After");
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= "+b);

        }
    }
}
