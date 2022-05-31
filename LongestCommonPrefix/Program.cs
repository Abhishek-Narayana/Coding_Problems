using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(data));
            Console.ReadLine();
        }

        private static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 2)
            {
                return string.Empty;
            }

            string longestPrefix = strs[0];
            for (int index = 1; index < strs.Length; index++)
            {
                longestPrefix = longestPrefix.GetCommanPrefix(strs[index]);

            }
            return longestPrefix;
        }
    }

    static class StringExtension
    {
        public static string GetCommanPrefix(this string strA, string strB)
        {
            if (string.IsNullOrEmpty(strA) || string.IsNullOrEmpty(strB))
            {
                return string.Empty;
            }

            int count = 0;
            for (int index = 0; index < Math.Min(strA.Length, strB.Length); index++, count++)
            {
                if (strA[index] != strB[index])
                {
                    break;
                }
            }
            return strA.Substring(0, count);
        }
    }
}
