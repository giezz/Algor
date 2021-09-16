using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double farenheit;

            for(double i = 15; i <= 30; i++)
            {
                farenheit = 1.8 * i + 32;
                Console.WriteLine($"{i} градусов цельсия  = {farenheit} градусов Фаренгейта");
            }
        }
    }
}
