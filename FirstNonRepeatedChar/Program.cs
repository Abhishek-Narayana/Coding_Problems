using System;

namespace FirstNonRepeatedChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello";
            Console.WriteLine(FirstNonRepeatedChar(input));
            Console.ReadLine();
        }

        private static char FirstNonRepeatedChar(string input)
        {
            if (string.IsNullOrEmpty(input))
                return ' ';

            if (input.Length == 1)
                return input[0];

            char[] charCount = new char[256];
            for (int count = 0; count < input.Length; count++)
                charCount[input[count]]++;

            for (int count = 0; count < input.Length; count++)
            {
                if (charCount[input[count]] == 1)
                    return input[count];
            }

            return ' ';
        }
    }
}
