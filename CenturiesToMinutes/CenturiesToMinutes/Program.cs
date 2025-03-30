using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter centuries: ");
            int vek = int.Parse(Console.ReadLine());
            int god = vek * 100;
            int dni = (int)(god * 365.2422);
            int chas = dni * 24;
            int min=chas*60;
            int sek = min * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes ={5} seconds", vek, god, dni, chas, min, sek);
        }
    }
}
