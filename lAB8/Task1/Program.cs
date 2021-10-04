using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new int[20];
            var arr2 = new int[3, 4];
            var positiveArray = new int[32];
            var random = new Random();
            int positiveCount = 0;


            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(-10, 10);
                if (arr1[i] > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(arr1[i] + " ");
                    Console.ResetColor();
                    positiveArray[positiveCount] = arr1[i];
                    positiveCount++;

                }
                else
                {
                    Console.Write(arr1[i] + " ");
                }
                
            }

            Console.WriteLine();

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = random.Next(-10, 10);
                    if (arr2[i, j] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(arr2[i, j] + " \t");
                        Console.ResetColor();
                        positiveArray[positiveCount] = arr2[i, j];
                        positiveCount++;
                    }
                    else
                    {
                        Console.Write(arr2[i, j] + " \t");
                    }
                }
                Console.WriteLine();  
            }

            Array.Resize(ref positiveArray, positiveCount);

            int temp = 0;
            for (int i = 0; i < positiveArray.Length; i++)
            {
                for (int j = 0; j < positiveArray.Length - 1; j++)
                {
                    if (positiveArray[j] > positiveArray[j + 1])
                    {
                        temp = positiveArray[j + 1];
                        positiveArray[j + 1] = positiveArray[j];
                        positiveArray[j] = temp;
                    }
                }
            }

            Array.Reverse(positiveArray);
            foreach (int i in positiveArray)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i + " ");
                Console.ResetColor();
            }
            Console.ReadLine();
        }
    }
}
