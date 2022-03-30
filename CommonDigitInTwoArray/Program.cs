using System;
using System.Collections.Generic;

namespace CommonDigitInTwoArray
{
    class Program
    {

        /// <summary>
        /// Given two sorted integer array find the common digit in it with best time complexity
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] array2 = new int[] { 0, 10, 15, 30, 40, 50 };
            int[] array1 = new int[] { 5, 15, 30, 50, 65, 120 };
            List<int> commonDigit = GetCommonDigit(array1, array2);
            commonDigit.ForEach(Console.WriteLine);

            Console.ReadLine();
        }

        /// <summary>
        /// Gets the common digit in two sorted array in O(n) times
        /// </summary>
        /// <param name="array_1"></param>
        /// <param name="array_2"></param>
        /// <returns></returns>
        private static List<int> GetCommonDigit(int[] array_1, int[] array_2)
        {
            if (array_1.Length == 0 || array_2.Length == 0)
                return null;

            List<int> commonDigit = new List<int>();
            int index_2 = 0;
            for (int index_1 = 0; index_1 < array_1.Length && index_2 < array_2.Length; index_1++)
            {
                while(index_2 < array_2.Length)
                {
                    if (array_1[index_1] > array_2[index_2])
                        index_2 += 1;
                    else if (array_1[index_1] < array_2[index_2])
                        break;
                    else
                    {
                        commonDigit.Add(array_1[index_1]);
                        index_2 += 1;
                        break;
                    }
                }
            }

            return commonDigit;
        }
    }
}
