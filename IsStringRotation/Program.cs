using System;

namespace IsStringRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "waterbottle";
            string s2 = "erbottlewat";
            Console.WriteLine(IsStringRotation(s1, s2));
            Console.ReadLine();
        }

        private static bool IsStringRotation(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return false;

            return (s1 + s1).Contains(s2);
        }
    }
}
