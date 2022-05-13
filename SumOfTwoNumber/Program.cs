using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SumOfTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            ReturnNumAddUpToSum(array, 11);
            Console.ReadLine();
        }

        private static int[] ReturnNumAddUpToSum(int[] nums, int target)
        {
            Hashtable visitedNums = new Hashtable();
            // Dictionary<int, int> visitedNums = new Dictionary<int, int>();

            for (int index = 0; index < nums.Length; index++)
            {
                if (visitedNums.ContainsKey(target - nums[index]))
                    return new int[] { (int)visitedNums[target - nums[index]], index };
                else if(!visitedNums.ContainsKey(nums[index]))
                    visitedNums.Add(nums[index], index);
            }
            return null;
        }
    }
}
