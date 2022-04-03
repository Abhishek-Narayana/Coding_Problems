//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//namespace StackProblem_1
//{
//    class Result
//    {

//        /*
//         * Complete the 'twoStacks' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts following parameters:
//         *  1. INTEGER maxSum
//         *  2. INTEGER_ARRAY a
//         *  3. INTEGER_ARRAY b
//         */

//        public static int twoStacks(int maxSum, List<int> a, List<int> b)
//        {
//            int sum = 0, count = -1;
//            for (int aTop = 0, bTop = 0; (a.Count > 0 || b.Count > 0) && sum <= maxSum; count++)
//            {
//                if (a[aTop] > b[bTop])
//                {
//                    sum += b[bTop];
//                    bTop++;
//                }
//                else
//                {
//                    sum += a[aTop];
//                    aTop++;
//                }
//            }
//            return count;
//        }
//    }

//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int maxSum = 55;
//            string number_1 = "11 6 1 13 14 7 8 10 3 17 7 18 6 4 5 13 17 4 16 9 17 16 12 6 7";
//            string number_2 = "10 15 13 17 10 7 0 16 8 13 11 8 14 13";

//            List<int> a = number_1.Split(' ').Select(Int32.Parse).ToList();
//            List<int> b = number_2.Split(' ').Select(Int32.Parse).ToList();

//            Console.WriteLine(Result.twoStacks(maxSum, a, b));
//            Console.ReadLine();
//        }
//    }
//}
