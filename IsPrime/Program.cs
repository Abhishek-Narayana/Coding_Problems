using System;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
            Console.ReadLine();
        }

        public static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
