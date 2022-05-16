using System;
using System.Text;

namespace LongestSortedSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "abcbcdeabcbcdeabcbcdeabcbcdeabcbcdedabcd";
            // string sentence = "a b c d e f g h i j k l d";
            Console.WriteLine(LongestSortedSubString(sentence));

            Console.ReadLine();
       }

        private static StringBuilder LongestSortedSubString(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return null;

            StringBuilder LongestString = new StringBuilder();
            StringBuilder tempLongestString = new StringBuilder(sentence[0]);
            char previousChar = sentence[0];
            for (int i = 1; i < sentence.Length; i++)
            {
                if (!sentence[i].IsAlphabet())
                {
                    if (tempLongestString.Length > LongestString.Length)
                    {
                        LongestString = tempLongestString;
                    }
                    tempLongestString = new StringBuilder();
                }
                else if (previousChar.IsAlphabet() && previousChar < sentence[i])
                {
                    if (tempLongestString.Length == 0)
                    {
                        tempLongestString.Append(previousChar);
                    }
                    tempLongestString.Append(sentence[i]);
                }
                else if (tempLongestString.Length > LongestString.Length)
                {
                    LongestString = tempLongestString;
                    tempLongestString = new StringBuilder();
                }
                else
                {
                    tempLongestString = new StringBuilder();
                }
                previousChar = sentence[i];
            }
            return tempLongestString.Length > LongestString.Length ? tempLongestString : LongestString;
        }
    }

    static class Extension
    {
        public static bool IsAlphabet(this char character)
        {
            return character > 64 && character < 91 || character > 96 && character < 123;
        }
    }
}
