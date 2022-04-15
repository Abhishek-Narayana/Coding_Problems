using System;
using System.Collections;
using System.Text;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetCompressedString("yyhheeeccckksssyybbee"));
            Console.ReadLine();
        }

        private static string GetCompressedString(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            StringBuilder result = new StringBuilder();
            for (int i = 0, count = 0; i < str.Length; i++)
            {
                count++;
                if ( i+1  == str.Length || str[i] != str[i+1])
                {
                    result.Append(str[i]);
                    result.Append(count);
                    count = 0;
                }
            }

            return result.ToString();
        }
    }
}
