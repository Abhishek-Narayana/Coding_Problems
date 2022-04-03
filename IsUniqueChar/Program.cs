using System;

namespace IsUniqueChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Helo";

            Console.WriteLine(IsUniqueChar(input));
            Console.ReadLine();

        }

        private static bool IsUniqueChar(string input)
        {
            if (string.IsNullOrEmpty(input) && (input.Length > char.MaxValue))
                return false;

            bool[] charPresence = new bool[char.MaxValue];
            for (int count = 0; count < input.Length - 1; count++)
            {
                if (!charPresence[input[count]])
                {
                    charPresence[input[count]] = true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
