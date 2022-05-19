using System;

namespace MaxWaterContainerCanHold
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.interviewbit.com/problems/container-with-most-water/
            // https://leetcode.com/problems/container-with-most-water/
            Program program = new Program();
            int[] container = new int[]{ 1, 3, 7, 2, 7, 3, 1 };
            Console.WriteLine(program.maxArea(container));
            Console.ReadLine();
        }

        public int maxArea(int[] height)
        {
            if (height.Length < 2)
                return 0;
            else if (height.Length == 2)
                return Math.Min(height[0], height[1]);

            int start = 0, end = height.Length - 1;
            int maxWater = Math.Min(height[start], height[end]) * (end - start);
            while ((end - start) != 1)
            {
                if (TryIncreasingCapacity(height, start + 1, end, ref maxWater))
                    start++;
                if (TryIncreasingCapacity(height, start, end - 1, ref maxWater))
                    end--;
                int _ = height[start] < height[end] ? start++ : end--;
            }
            return maxWater;
        }

        private static bool TryIncreasingCapacity(int[] container, int start, int end, ref int curMax)
        {
            int result = Math.Min(container[start], container[end]) * (end - start);
            if (result > curMax)
                curMax = result;
            return result > curMax;
        }
    }
}
