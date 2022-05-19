using System;

namespace TrappingMaximumRainWater
{
    class Program
    {
        static void Main(string[] args)
        {
            https://practice.geeksforgeeks.org/problems/trapping-rain-water-1587115621/1
            Console.WriteLine("Hello World!");
            int[] data = new int[] { 3, 0, 0, 2, 0, 4 };
            Console.WriteLine(TrappingMaximumRainWater(data));
            Console.ReadLine();
        }

        private static int TrappingMaximumRainWater(int[] height)
        {
            int trappedwater = 0;
            int left_max = int.MinValue, righ_max = int.MinValue;
            int[] rightData = new int[height.Length];
            int[] leftData = new int[height.Length];

            // Compute left max for each position
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > left_max)
                {
                    left_max = height[i];
                }
                leftData[i] = left_max;
            }
            
            // Compute right max for each position
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > righ_max)
                {
                    righ_max = height[i];
                }
                rightData[i] = righ_max;
            }

            for (int index = 0; index < height.Length; index++)
            {
                trappedwater += Math.Min(leftData[index], rightData[index]) - height[index];
            }

            return trappedwater;
        }
    }
}
