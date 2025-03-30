using System;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            Console.WriteLine(Math.Round(area,12));
            Console.WriteLine("{0:f12}", area);
        }
    }
}
