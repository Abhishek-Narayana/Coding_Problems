using System;

namespace ReplaceSpaceWithGivenSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(ReplaceSpaceWithGivenSubstring("    Hi how are you    ", "__"));
            Console.WriteLine(ReplaceTabspaceWithGivenSubstring("Hi         how are    you", "_TabSpace_"));
            Console.ReadLine();
        }

        private static string ReplaceSpaceWithGivenSubstring(string sentence, string replacer)
        {
            if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(sentence))
                return string.Empty;

            char[] result = new char[sentence.Length];
            sentence = sentence.Trim();
            for (int sentencePtr = 0, resultPtr = 0; sentencePtr < sentence.Length; sentencePtr++)
            {
                if (sentence[sentencePtr] != ' ')
                {
                    result[resultPtr++] = sentence[sentencePtr];
                }
                else
                {
                    Array.Resize(ref result,  result.Length + replacer.Length - 1);
                    for (int count = 0; count < replacer.Length; count++)
                    {
                        result[resultPtr++] = replacer[count];
                    }
                }
            }

            return new string(result);
        }

        private static string ReplaceTabspaceWithGivenSubstring(string sentence, string replacer)
        {
            if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(sentence))
                return string.Empty;

            char[] result = new char[sentence.Length];
            sentence = sentence.Trim();
            for (int sentencePtr = 0, resultPtr = 0, tabSpaceCount = 0; sentencePtr < sentence.Length; sentencePtr++)
            {
                if (sentence[sentencePtr] != ' ')
                {
                    if(tabSpaceCount == 4)
                    {
                        tabSpaceCount = 0; // reset the counter
                        Array.Resize(ref result, result.Length + replacer.Length - 1);
                        for (int count = 0; count < replacer.Length; count++)
                        {
                            result[resultPtr++] = replacer[count];
                        }
                    }
                    while(tabSpaceCount > 0)
                    {
                        result[resultPtr++] = ' ';
                        tabSpaceCount--;
                    }
                    result[resultPtr++] = sentence[sentencePtr];
                }
                else
                {
                    tabSpaceCount++;
                }
            }

            return new string(result);
        }
    }
}
