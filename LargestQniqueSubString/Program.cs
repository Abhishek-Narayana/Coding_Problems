using System;
using System.Collections.Generic;

namespace LargestQniqueSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestUniqueSubString("AAAAA"));
            Console.ReadLine();
        }

        public static string LongestUniqueSubString(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            string longestQniqueSubString = string.Empty;
            HashSet<char> uniqueChars = new HashSet<char>();
            for(int left = 0, right = 0 ; right <= input.Length - 1;)
            {
                if(uniqueChars.Add(input[right])) // true if incoming char is unique
                {
                    right++;
                    if (uniqueChars.Count > longestQniqueSubString.Length)
                    {
                        longestQniqueSubString = input.Substring(left, right - left);
                    }
                }
                else
                {
                    uniqueChars.Remove(input[left]);
                    left++;
                }
            }
            return longestQniqueSubString;
        }
    }
}
