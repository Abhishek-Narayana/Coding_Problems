using System;

namespace AreStringsEqualOnSingleEdit
{
    class Program
    {
        // There are three types of edits that can be performed on strings
        // insert a character, remove a chance replace a character.
        // Given two strings, write a function to check if they are one edit (or zero edits) away.
        static void Main(string[] args)
        {
            Console.WriteLine(AreStringsEqualOnSingleEdit("pale", "pales")); // true
            Console.WriteLine(AreStringsEqualOnSingleEdit("pale", "bale")); // true
            Console.WriteLine(AreStringsEqualOnSingleEdit("pale", "ple")); // true
            Console.WriteLine(AreStringsEqualOnSingleEdit("a", "b")); // true
            Console.WriteLine(AreStringsEqualOnSingleEdit("abcde", "aacce")); // false
            Console.WriteLine(AreStringsEqualOnSingleEdit("pale", "bake")); // false
            Console.ReadLine();
        }

        private static bool AreStringsEqualOnSingleEdit(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)
                || (s1.Length - s2.Length) < -1 || (s1.Length - s2.Length) > 1)
                return false;

            int DiffCount = 0;
            int s1Ptr = 0, s2Ptr = 0;
            for (; DiffCount < 2 && s1Ptr < s1.Length && s2Ptr < s2.Length; s1Ptr++, s2Ptr++)
            {
                if (s1[s1Ptr] != s2[s2Ptr])
                {
                    DiffCount++;
                    if(s1.Length != s2.Length)
                    {
                        int _ = s1.Length < s2.Length ? s1Ptr-- : s2Ptr--;
                    }
                }
            }
            if (s1Ptr + 1 == s1.Length || s2Ptr + 1 == s2.Length)
            {
                DiffCount++;
            }
            return DiffCount == 1;
        }
    }
}
