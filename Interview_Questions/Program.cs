using System;

namespace Interview_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine("Number before swapping number 1:{0} number 2: {1}", num1, num2);
            Program.SwapNubers(num1, ref num2);
            Program.SwapNubers(num2, ref num1);
            Console.WriteLine("Number After swapping number 1:{0} number 2: {1}", num1, num2);
        }

        public static int SwapNubers(int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;

            return num1;
        }

        //public static long SwapNubers(int num1, ref int num2)
        //{
        //    int temp = num1;
        //    num1 = num2;
        //    num2 = temp;

        //    return num1;
        //}
    }
}
