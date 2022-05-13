using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GivenStringSplittedIntoWordsIsPresentInDictionary
{
    // TODO
    // https://leetcode.com/problems/word-break/submissions/
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> list = new List<string>() { "aa", "apple", "pen" };
            Console.WriteLine(IsWordsPresentInDictionary(list, "applepenapple"));
            // IList<string> list = new List<string>() { "aaaa", "aaa" };
            // Console.WriteLine(IsWordsPresentInDictionary(list, "aaaaaaa"));
            Console.ReadLine();
        }

        private static bool IsWordsPresentInDictionary(IList<string> wordDict, string s)
        {
            wordDict.OrderBy(x => x.Length);
            foreach (string word in wordDict)
            {
                while(s.Contains(word))
                {
                    int index = s.IndexOf(word);
                    s = s.Remove(index, word.Length);
                }
            }
            return s.Length == 0;
        }
    }
}
