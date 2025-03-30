using System;

namespace SpeedConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = float.Parse(Console.ReadLine());
            var h = float.Parse(Console.ReadLine());
            var m = float.Parse(Console.ReadLine());
            var s = float.Parse(Console.ReadLine());

            var t = h * 3600 + m * 60 + s;
            var ms = n / t;
            var kmh = (n / 1000) / (t/3600);
            var mh = (n / 1609) / (t/3600);

            Console.WriteLine("{0}", ms);
            Console.WriteLine("{0}", kmh);
            Console.WriteLine("{0}", mh);

        }
    }
}
