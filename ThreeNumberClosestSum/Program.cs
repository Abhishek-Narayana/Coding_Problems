using System;
using System.Collections.Generic;

namespace ThreeNumberClosestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] data = new int[] { 1, -1, -4, 2 };

            int[] data = new int[] { -1, -3, 5, 7, -4, 6, -5 };
            // int[] data = new int[] { 6, 1, 4, 9, 7, 2, 3, 8, 5 };

            ThreeNumberClosestSum(data, 3);

            Console.ReadLine();
        }

        private static List<int> ThreeNumberClosestSum(int[] data, int target)
        {
            Array.Sort(data);

            #region Get nearest number to target
            int nearestNumToTarget = int.MinValue;
            for (int index = 0, nearestDiff = int.MaxValue; index < data.Length - 1; index++)
            {
                int newDiff = target > data[index] ? target - data[index] : data[index] - target;
                if (newDiff > nearestDiff)
                    break;
                nearestDiff = newDiff;
                nearestNumToTarget = data[index];
            }
            #endregion
            for (int left = 0, right = data.Length - 1, closestDiff = int.MaxValue; left < right;)
            {
                int sum = data[left] + nearestNumToTarget + data[right];
                int newDiff = target > sum ? target - sum : sum - target;
                if (newDiff == 0 || newDiff > closestDiff)
                {
                    return new List<int>() { data[left], nearestNumToTarget, data[right] };
                }
                else
                {
                    closestDiff = newDiff;
                    int leftDiff = data[left] - nearestNumToTarget;
                    int rightDiff = data[right] - nearestNumToTarget;
                }

                // -4 -3 2 5 7 10 15 = 5
            }

            return new List<int>();
        }
    }
}
