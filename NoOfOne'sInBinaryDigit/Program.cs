using System;

namespace NoOfOne_sInBinaryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNumberOfOnes(21));
            Console.ReadLine();
        }

        private static int FindNumberOfOnes(int number)
        {
            int numberOfOne = 0;
            while (number > 0)
            {
                if(number % 2 == 1)
                {
                    numberOfOne += 1;
                }
                number /= 2;
            }
            return numberOfOne;
        }
    }
}
