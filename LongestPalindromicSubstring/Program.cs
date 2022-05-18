using System;
using System.Collections.Generic;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindromicSubstring("a"));
            Console.WriteLine(LongestPalindromicSubstring("aa"));
            Console.WriteLine(LongestPalindromicSubstring("aaa"));
            Console.WriteLine(LongestPalindromicSubstring("ab"));
            Console.WriteLine(LongestPalindromicSubstring("aba"));
            Console.WriteLine(LongestPalindromicSubstring("abaa"));
            Console.WriteLine(LongestPalindromicSubstring("babad"));
            Console.WriteLine(LongestPalindromicSubstring("cbbd"));
            Console.ReadLine();
        }

        private static string LongestPalindromicSubstring(string s)
        {
            string longestPalindrome = string.Empty;

            for (int index = 0; index < s.Length; index++)
            {
                if ((index + 2) < s.Length && s[index] == s[index + 2])
                {
                    UpdateLongestPalidrome(ref longestPalindrome, GetPalidrome(s, index, index + 2));
                }
                if ((index + 1) < s.Length && s[index] == s[index + 1])
                {
                    UpdateLongestPalidrome(ref longestPalindrome, GetPalidrome(s, index, index + 1));
                }
                if (string.IsNullOrEmpty(longestPalindrome))
                {
                    longestPalindrome = s[index].ToString();
                }
            }
            return longestPalindrome;
        }

        private static void UpdateLongestPalidrome(ref string longestPalindrome, string newPalidrome)
        {
            if (newPalidrome.Length > longestPalindrome.Length)
            {
                longestPalindrome = newPalidrome;
            }
        }

        private static string GetPalidrome(string inputString, int left, int right)
        {
            int length = ((left + right) % 2 == 0) ? 1 : 0;
            while (left >= 0 && right < inputString.Length // index outof bound validation
                && inputString[left] == inputString[right]) // Palindrome validation
            {
                left--;
                right++;
                length += 2;
            }
            return inputString.Substring(left + 1, length);
        }
    }
}
