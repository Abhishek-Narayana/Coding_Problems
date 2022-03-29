using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumRepeatedChar
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in MaximumRepeatedChar("abbbbaa"))
            {
                Console.WriteLine("{0}", item);
            }

            Console.ReadLine();
        }

        static char[] MaximumRepeatedChar(string inputString)
        {
            if (inputString == null)
                return null;

            Dictionary<char, int> dict = new();
            List<char> repeatedChar = new();
            foreach (char item in inputString)
            {
                var _ = dict.ContainsKey(item) ? dict[item] = dict[item] + 1 : dict[item] = 1;
            }

            int max = dict.Values.Max();
            foreach (KeyValuePair<char, int> item in dict)
            {
                if(item.Value == max)
                {
                    repeatedChar.Add(item.Key);
                }
            }

            return repeatedChar.ToArray();
        }
    }
}
