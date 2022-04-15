using System;
using System.Collections.Generic;

namespace RomanToDecimal
{
    public class RomanToDecimalConverter
    {
        protected Dictionary<char, int> RomanDigit = new Dictionary<char, int>()
        { {'I', 1 }, {'V', 5 }, {'X', 10 }, {'L', 50 }, {'C', 100 }, {'D', 500 }, {'M', 1000 } };
        
        static void Main(string[] args)
        {
            RomanToDecimalConverter program = new RomanToDecimalConverter();
            Console.WriteLine(program.RomanToDecimal("XCIX"));
            Console.ReadLine();
        }

        public int RomanToDecimal(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int decimalValue = 0;
            for (int index = 0; index < s.Length; index++)
            {
                if (index + 1 >= s.Length || RomanDigit[s[index]] >= RomanDigit[s[index + 1]])
                    decimalValue += RomanDigit[s[index]];
                else
                    decimalValue += RomanDigit[s[index + 1]] - RomanDigit[s[index++]];
            }
            return decimalValue;
        }
    }
}
