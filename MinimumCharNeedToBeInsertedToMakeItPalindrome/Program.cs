using System;

namespace MinimumCharNeedToBeInsertedToMakeItPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = MinimumCharNeedToBeInsertedToMakeItPalindrome("abcba");
            Console.WriteLine(count);
            Console.ReadLine();
        }

        private static int MinimumCharNeedToBeInsertedToMakeItPalindrome(string s)
        {
            int Count = 0;
            for (int start = 0, end = s.Length - 1; start < end; start++)
            {
                if (s[start] != s[end])
                {
                    Count++;
                    continue;
                }
                else
                {
                    end--;
                }
            }
            return Count;
        }
    }
}
