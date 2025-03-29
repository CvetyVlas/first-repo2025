using System;

namespace HexadecimalConvert
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = int.Parse(Console.ReadLine());
            string b = Convert.ToString(a, 16).ToUpper();
            string c = Convert.ToString(a, 2).ToUpper();
            Console.WriteLine(b);
            Console.WriteLine(c);


            //string a = Console.ReadLine();
            //int b = Convert.ToInt32(a, 16);
            //int c = Convert.ToInt32(a, 2);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
        }
    }
}
