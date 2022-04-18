using System;
using System.Collections.Generic;

namespace MaxWaterContainerCanHold
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.interviewbit.com/problems/container-with-most-water/
            Program program = new Program();
            List<int> container = new List<int>(){ 1, 3, 7, 2, 7, 3, 1 };
            Console.WriteLine(program.maxArea(container));
            Console.ReadLine();
        }

        public int maxArea(List<int> container)
        {
            if (container.Count < 2)
                return 0;
            else if (container.Count == 2)
                return Math.Min(container[0], container[1]);

            int start = 0, end = container.Count - 1;
            int maxWater = Math.Min(container[start], container[end]) * (end - start);
            while ((end - start) != 1)
            {
                if (TryIncreasingCapacity(container, start + 1, end, ref maxWater))
                    start++;
                if (TryIncreasingCapacity(container, start, end - 1, ref maxWater))
                    end--;
                int _ = container[start] < container[end] ? start++ : end--;
            }
            return maxWater;
        }

        private static bool TryIncreasingCapacity(List<int> container, int start, int end, ref int curMax)
        {
            int result = Math.Min(container[start], container[end]) * (end - start);
            if (result > curMax)
                curMax = result;
            return result > curMax;
        }
    }
}
