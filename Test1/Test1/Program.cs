using System;
using System.Diagnostics;

namespace Test1
{
    class Program
    {
        public int[] x = new int[100000000];
        static void Main(string[] args)
        {
            var stopWatchA = new Stopwatch();
            var stopWatchB = new Stopwatch();
            var prog = new Program();
            
            stopWatchA.Start();
            prog.A();
            stopWatchA.Stop();

            stopWatchB.Start();
            prog.B();
            stopWatchB.Stop();

            Console.WriteLine($"A \t{stopWatchA.Elapsed}\nB \t{stopWatchB.Elapsed}");
        }

        void A()
        {
            var y = x;
            for (int i = 0; i < 100000000; i++)
            {
                y[i] = i;
            }
        }

        void B()
        {
            for (int i = 0; i < 100000000; i++)
            {
                x[i] = i;
            }
        }
    }
}
