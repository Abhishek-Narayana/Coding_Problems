using System;
using System.Diagnostics;

namespace TimeComplecity
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var start = watch.ElapsedMilliseconds;
            SingleForLoop();
            var end = watch.ElapsedMilliseconds;
            Console.WriteLine("Time taken {0}", end - start);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static int SingleForLoop()
        {
            return 2 * 10;
        }
    }
}
