using System;
using System.Collections.Generic;
using System.Linq;

namespace TallestCylinder
{
    class Program
    {
        /// <summary>
        /// Refer this page from problem statement : https://www.hackerrank.com/challenges/equal-stacks/problem
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> h1 = new List<int>() { 1, 1, 1, 1, 1};
            List<int> h2 = new List<int>() { 3, 2 };
            List<int> h3 = new List<int>() { 1, 3, 1 };

            Console.WriteLine("Tallest cylinder {0}", TallestCylinder(h1, h2, h3));

            Console.ReadLine();
        }

        public static int TallestCylinder(List<int> h1, List<int> h2, List<int> h3)
        {
            h1.Reverse();
            h2.Reverse();
            h3.Reverse();
            FindSumOfPrevious(h1);
            FindSumOfPrevious(h2);
            FindSumOfPrevious(h3);

            var common = h1.Intersect(h2).Intersect(h3);
            return common.Any() ? common.Max() : 0;
        }

        public static void FindSumOfPrevious(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                list[i] = list[i - 1] + list[i];
            }
        }
    }
}
