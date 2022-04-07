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

        private static bool AreStringsEqualOnSingleEdit(string string_1, string string_2)
        {
            if (string.IsNullOrEmpty(string_1) || string.IsNullOrEmpty(string_2)
                || (string_1.Length - string_2.Length) < -1 || (string_1.Length - string_2.Length) > 1)
                return false;

            int DiffCount = 0;
            int str_1_Ptr = 0, str_2_Ptr = 0;
            while (DiffCount < 2 && str_1_Ptr < string_1.Length && str_2_Ptr < string_2.Length)
            {
                if (string_1[str_1_Ptr] == string_2[str_2_Ptr])
                {
                    str_1_Ptr++;
                    str_2_Ptr++;
                }
                else if (string_1.Length == string_2.Length)
                {
                    DiffCount++;
                    str_1_Ptr++;
                    str_2_Ptr++;
                }
                else
                {
                    DiffCount++;
                    int _ = string_1.Length > string_2.Length ? str_1_Ptr++ : str_2_Ptr++;
                }
            }
            if (str_1_Ptr + 1 == string_1.Length || str_2_Ptr + 1 == string_2.Length)
            {
                DiffCount++;
            }
            return DiffCount == 1;
        }
    }
}
