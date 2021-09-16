using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер осеннего месяца");
            int x = Convert.ToInt32(Console.ReadLine());

            switch(x)
            {
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                default:
                    Console.WriteLine("Месяц не осенний");
                    break;
            }
        }
    }
}
