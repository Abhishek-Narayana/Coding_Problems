using System;

namespace StrictMountain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrictMountain(new int[5] { 1,2,3,4,1}));
            Console.ReadKey();
        }

        private static bool StrictMountain(int[] input)
        {
            if (input.Length < 3)
                return false;

            int leftPtr = 0, rightPtr = input.Length - 1;
            while (leftPtr < rightPtr  && input[leftPtr] < input[leftPtr + 1])
            {
                leftPtr++;
            }
            if (leftPtr == 0 || leftPtr == input.Length - 1)
                return false;

            while (leftPtr < rightPtr && input[rightPtr - 1] > input[rightPtr])
            {
                rightPtr--;
            }
            if (rightPtr == input.Length - 1)
                return false;

            return leftPtr == rightPtr;
        }
    }
}
