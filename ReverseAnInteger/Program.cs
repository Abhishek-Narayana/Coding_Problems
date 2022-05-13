using System;

namespace ReverseAnInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseAnInteger(-10));
            Console.ReadLine();
        }

        private static int ReverseAnInteger(int num)
        {
            long sum = 0;
            while(num != 0)
            {
                sum = sum * 10 + (num % 10);
                num /= 10;
            }
            return (sum < int.MinValue || sum > int.MaxValue) ? 0 : (int)sum;
        }
    }
}
