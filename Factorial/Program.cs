using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num));
            Console.ReadLine();
        }

        public static int Factorial(int num)
        {
            if (num <= 1)
                return 1;
            return num * Factorial(num - 1);
        }
    }
}
