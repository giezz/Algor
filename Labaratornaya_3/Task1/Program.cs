using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = 3 * Math.PI;
            double step = Math.PI / 2;
            double y;

            for (double i = A; i <= B; i += step)
            {
                y = 0.5 * i + Math.Pow(Math.Sin(i), 2);
                Console.WriteLine($"x = {i} , y = {y}");
            }
        }
    }
}
