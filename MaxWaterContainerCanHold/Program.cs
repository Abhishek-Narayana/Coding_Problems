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
            List<int> container = new List<int>(){ 1, 20, 20, 1 };
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
            int maxWater = 0;
            while (start < end)
            {
                int result = Math.Min(container[start], container[end]) * (end - start);
                if (result > maxWater)
                    maxWater = result;
                int _ = container[start] < container[end] ? start++ : end--;
            }
            return maxWater;
        }
    }
}
