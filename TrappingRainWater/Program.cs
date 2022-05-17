using System;

namespace TrappingRainWater
{
    class Program
    {
        // https://practice.geeksforgeeks.org/problems/trapping-rain-water-1587115621/1
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] data = new int[] { 3, 0, 0, 2, 0, 4 };
            Console.WriteLine(MaximumRainWaterTrapped(data));
            Console.ReadLine();
        }

        private static int MaximumRainWaterTrapped(int[] data)
        {
            int trappedWater = 0;
            int left_max = int.MinValue, righ_max = int.MinValue;
            int[] leftData = new int[data.Length];
            int[] rightData = new int[data.Length];

            // Compute left max for each position
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > left_max)
                    left_max = data[i];
                leftData[i] = left_max;
            }
            // Compute right max for each position
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > righ_max)
                    righ_max = data[i];
                rightData[i] = righ_max;
            }

            for (int index = 0; index < data.Length; index++)
            {
                trappedWater += Math.Min(leftData[index], rightData[index]) - data[index];
            }
            return trappedWater;
        }
    }
}
