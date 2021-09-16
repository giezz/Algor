using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativeCount = 0;
            int positiveCount = 0;
            int[] arr = new int[20];
            Random random = new Random();

            for (int i = 0; i <arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
                Console.Write(arr[i] + " ");

                if (arr[i] > 0) positiveCount++;
                if (arr[i] < 0) negativeCount++;
            }

            Console.WriteLine($"\n Положительных чисел в массиве: {positiveCount} \n Отрицательных чисел в массиве: {negativeCount}");
        }
    }
}
