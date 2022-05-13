using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerToRoman
{
    // TODO
    class Program
    {
        Dictionary<char, int> RomanNumbers =
            new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(3));
            Console.WriteLine(IntToRoman(58));
            Console.WriteLine(IntToRoman(1994));
            Console.Read();
        }
        public static string IntToRoman(int num)
        {
            if (num < 0 || num > 3999)
                return null;

            StringBuilder roman = new StringBuilder(9);
            while (num > 0)
            {
                if (num > 1000)
                {
                    roman.Append('M');
                    num -= 1000;
                }
                else if(num > 900)
                {
                    roman.Append("CM");
                    num -= 900;
                }
                else if (num > 500)
                {
                    roman.Append('D');
                    num -= 500;
                }
                else if (num > 400)
                {
                    roman.Append("CD");
                    num -= 400;
                }
                else if (num > 100)
                {
                    roman.Append('C');
                    num -= 100;
                }
                else if (num > 90)
                {
                    roman.Append("XC");
                    num -= 90;
                }
                else if (num > 50)
                {
                    roman.Append('L');
                    num -= 50;
                }
                else if (num > 40)
                {
                    roman.Append("XL");
                    num -= 40;
                }
                else if (num > 10)
                {
                    roman.Append('X');
                    num -= 10;
                }
                else if (num == 9)
                {
                    roman.Append("IX");
                    num -= 9;
                }
                else if (num > 5)
                {
                    roman.Append('V');
                    num -= 5;
                }
                else if (num == 4)
                {
                    roman.Append("IV");
                    num -= 4;
                }
                else
                {
                    roman.Append('I');
                    num -= 1;
                }
            }
            return roman.ToString();
        }
    }
}
