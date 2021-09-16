using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Random random = new Random();

            int temp = 10000;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
                Console.Write(arr[i] + " ");

                if (arr[i] > 0)
                {
                    if (arr[i] < temp) temp = arr[i];
                }
            }

            Console.WriteLine($"\n Наименшьий положительный элемент массива: {temp}");
        }
    }
}
