using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(num));
            Console.ReadLine();
        }

        public static int Fibonacci(int num)
        {
            if (num <= 1)
                return num;

            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}
