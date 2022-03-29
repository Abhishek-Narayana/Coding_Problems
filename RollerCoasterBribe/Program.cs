using System;
using System.Collections.Generic;

namespace RollerCoasterBribe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem statement
            // https://www.hackerrank.com/challenges/new-year-chaos/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays

            MinimumBribes(new List<int>() { 2, 1, 5, 3, 4 });

            Console.ReadLine();
        }

        public static void MinimumBribes(List<int> people)
        {
            for (int cur = 0; cur < people.Count; cur++)
            {
                if ((cur + 1) != people[cur])
                {
                    int minPosition = FindMinimumNumberPosition(people, cur);
                    SwapCurrentWithMinimumNumber(people, cur, minPosition);
                }
            }
        }

        private static void SwapCurrentWithMinimumNumber(List<int> people, int cur, int minPosition)
        {
            throw new NotImplementedException();
        }

        private static int FindMinimumNumberPosition(List<int> people, int cur)
        {
            int min = int.MinValue;
            int minPosition = int.MinValue;
            for (; cur < people.Count; cur++)
            {
                if (people[cur]< min)
                {
                    minPosition = cur;
                }
            }
            return minPosition;
        }
    }
}
