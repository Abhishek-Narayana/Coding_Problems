using System;
using System.Text;

namespace ReverseWordInASentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWordInSentence("12345 789"));
            Console.ReadLine();
        }

        private static StringBuilder ReverseWordInSentence(string inputString)
        {
            StringBuilder newSentence = new();
            foreach (string item in inputString.Split(' '))
            {
                newSentence.Append(item.Reverse() + ' ');
            }
            return newSentence;
        }
    }

    static class Extension
    {
        public static string Reverse(this string input)
        {
            char[] tempString = input.ToCharArray();
            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                char temp = tempString[i];
                tempString[i] = tempString[j];
                tempString[j] = temp;
            }
            return new string(tempString);
        }
    }
}
