using System;
using System.Collections.Generic;

namespace LongestSubStringWithUniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "abcdefgdegh";
            Console.WriteLine(GetLongestSubstringWithUniqueCharacter(input));
            Console.ReadLine();
        }

        private static string GetLongestSubstringWithUniqueCharacter(string input)
        {
            HashSet<char> uniqueChar = new HashSet<char>();
            string longestSubstring = string.Empty;
            for (int index = 0; index < input.Length; index++)
            {
                if (!uniqueChar.Add(input[index]))
                {
                    UpdateLongestSubString(uniqueChar, ref longestSubstring);
                    // we should start searching for new uniqueCharSubString after the char which is spoiling uniqueness  
                    index = input.IndexOf(input[index], index - uniqueChar.Count);
                    uniqueChar.Clear();
                }
            }
            UpdateLongestSubString(uniqueChar, ref longestSubstring);
            return longestSubstring;
        }

        private static void UpdateLongestSubString(HashSet<char> uniqueChar, ref string longestSubstring)
        {
            longestSubstring = uniqueChar.Count > longestSubstring.Length ? string.Join("", uniqueChar) : longestSubstring;
        }
    }
}
