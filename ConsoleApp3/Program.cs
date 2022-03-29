using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            You are given a string S of length N which encodes a non-negative number in a binary form.
            Two types of operations may be performed on it to modify its value:
            if V is odd, subtract 1 from it; if V is even, divide it by 2.
            These operations are performed until the value of V becomes 0.
            For example, if string S= '011100", its value V initially is 28. 
            
            The value of V would change as follows:
            V=28, which is even: divide by 2 to obtain 14;
            V-14, which is even: divide by 2 to obtain 7, -V-7, which is odd: subtract 1 to obtain 6;
            V-6, which is even: divide by 2 to obtain 3; .V-3, which is odd: subtract 1 to obtain 2:
            V-2, which is even: divide by 2 to obtain 1; V=1, which is odd: subtract 1 to obtain 0.

            Seven operations were required to reduce the value of V to 0.
             */

            Console.WriteLine(calculateOperations("011100"));
            Console.ReadLine();
        }

        private static int calculateOperations(string inputString)
        {
            int numberOfOperation = 0;
            char[] binaryString = inputString.ToCharArray();

            int startingPoint = 0;
            while(startingPoint < binaryString.Length - 1 
                && binaryString[startingPoint] == '0')
            {
                startingPoint++;
            }

            for (int row = startingPoint; row <= binaryString.Length - 1; row++)
            {
                var _ = binaryString[row] == '1' ? numberOfOperation += 2 : numberOfOperation += 1;
            }
            return numberOfOperation - 1;
        }
    }
}
