using System;

namespace FindSquareRootOfSortedWholeNumber
{

    /// <summary>
    /// Given an integer array numbers sorted in increasing order, return an array of the squares of each number sorted in increasing order.
    /// Input : -4, -1, 0, 3, 10
    /// Output : 0, 1, 9, 16, 100
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { -4, -3, -2, -1 };
            int[] array2 = new int[] { 1, 2, 3, 4 };
            int[] array3 = new int[] { -4, -1 , 0, 2, 5,};

            PrintArray(FindSquareRootOfSortedWholeNumber(array1));

            Console.ReadLine();
        }

        private static void PrintArray(int[] vs)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                Console.Write(vs[i]);
                Console.Write(' ');
            }
        }

        private static int[] FindSquareRootOfSortedWholeNumber(int[] array)
        {
            int negindex = -1, posIndex = array.Length;
            for (int i = 0; i < array.Length && array[i] < 0; i++, negindex++) { }

            if (negindex != array.Length - 1)
                posIndex = negindex + 1;

            int[] result = new int[array.Length];
            for (int index = 0; index <= array.Length; index++)
            {
                int num1 = negindex >= 0 ? array[negindex] * array[negindex] : 0;
                int num2 = posIndex < array.Length ? array[posIndex] * array[posIndex] : 0;
                if (num1 < num2)
                {
                    result[index] = num1;
                    negindex--;
                }
                else
                {
                    result[index] = num2;
                    posIndex++;
                }
            }
            return result;
        }
    }
}
