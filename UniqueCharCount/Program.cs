using System;
using System.Linq;
using System.Collections.Generic;

namespace UniqueCharCount
{
    class Program
    {
        // Given a string, get the count of each char to be removed so that each char count is unique.
        // Ex : aaaabbbb => removing 'b' once makes char count as a = 4, b = 3.
        // Ex : aaaabbbbcccc => removing 'b' once and removing 'c' twice makes char count as a = 4, b = 3, c = 2.
        // Ex : aaabbbcccddd => removing 'b' 1 time , removing 'c' 2 time and removing 'd' 3 times makes char count as a = 3, b = 2, c = 1.

        public Dictionary<char, int> charCollection = new Dictionary<char, int>();
        public Dictionary<char, int> removedCharCollection = new Dictionary<char, int>();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.UpdateCharCollectionToHaveUniqueCharCount("aaabbbccc");

            foreach (KeyValuePair<char, int> item in program.removedCharCollection)
            {
                Console.WriteLine($"Remove the {item.Key} : {item.Value} times");
            }
            Console.ReadLine();
        }

        private void UpdateCharCollectionToHaveUniqueCharCount(string inputString)
        {
            UpdateCharCount(inputString);
            RemoveDuplicateCharFromCollection();
        }

        private void RemoveDuplicateCharFromCollection()
        {
            HashSet<int> knownValues = new HashSet<int>();
            foreach (KeyValuePair<char, int> item in charCollection)
            {
                int charCount = item.Value;
                while (charCount > 0)
                {
                    if (!knownValues.Add(charCount))
                    {
                        charCount -= 1;
                    }
                    else
                    {
                        break;
                    }
                }
                if (item.Value - charCount > 0)
                {
                    removedCharCollection.Add(item.Key, item.Value - charCount);
                }
            }
        }

        private void UpdateCharCount(string inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if (charCollection.ContainsKey(inputString[i]))
                {
                    charCollection[inputString[i]] += 1;
                }
                else
                {
                    charCollection.Add(inputString[i], 1);
                }
            }
        }
    }
}
