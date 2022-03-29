using System;

namespace LargestNumberInAnArray
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Problem statement
            // Given an array of intefer, find the maximum number in it.
            // Note : Array items will be in the order of increasing and then decreasing.

            // Sample 1: [10, 20, 30, 40, 55, 42, 30, 28, 12] output => 55 
            // Sample 2: [55, 42, 30, 28, 12] output => 55
            int[] data = new int[] {66, 30, 28, 12 };

            FindLargestNumber(data);

            Console.ReadLine();
        }

        private static void FindLargestNumber(int[] data)
        {
            int min = 0;
            int max = data.Length - 1;

            while(min < max)
            {
                int middle = (min + max) / 2;
                if (data[middle] > data[middle + 1])
                {
                    max = middle;
                }
                else
                {
                    min = middle + 1;
                }
            }
            Console.WriteLine("Largest :" + data[max].ToString());
        }
    }
}
