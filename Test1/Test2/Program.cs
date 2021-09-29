using System;
using System.Diagnostics;

namespace Test2
{
    class Program
    {
        public int[] _a = new int[10000000];
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
            var a = _a;
            var c = new int[a.Length];
            for (int i = 0; i <= a.Length - 1; i++)
            {
                c[i] = a[i];
            }
        }

        void B()
        {
            var a = _a;
            var c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
        }
    }
}
