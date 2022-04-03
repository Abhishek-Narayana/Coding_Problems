using System;

namespace S2isPermutationOfS1
{
    class Program
    {
        static void Main(string[] args)
        {
            string S1 = "ABCD";
            string S2 = "BCDF";

            Console.WriteLine(S2isPermutationOfS1(S1, S2));
            Console.ReadLine();
        }

        private static bool S2isPermutationOfS1(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2) || s1.Length != s2.Length)
                return false;

            int s1Count = 0, s2Count = 0;
            for (int count = 0; count < s1.Length; count++)
            {
                s1Count += s1[count];
                s2Count += s2[count];
            }

            return s1Count == s2Count;
        }
    }
}
