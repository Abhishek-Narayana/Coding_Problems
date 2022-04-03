using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'twoStacks' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER maxSum
     *  2. INTEGER_ARRAY a
     *  3. INTEGER_ARRAY b
     */

    public static int twoStacks(int maxSum, List<int> a, List<int> b)
    {
        int sum = 0, count = 0;
        for (int aTop = 0, bTop = 0; (aTop < a.Count || bTop < b.Count) && sum <= maxSum; count++)
        {
            
            if (aTop < a.Count && bTop < b.Count)
            {
                if (a[aTop] < b[bTop])
                {
                    sum += a[aTop];
                    aTop++;
                }
                else
                {
                    sum += b[bTop];
                    bTop++;
                }
            }
            else if(aTop < a.Count)
            {
                sum += a[aTop];
                aTop++;
            }
            else if (bTop < b.Count)
            {
                sum += b[bTop];
                bTop++;
            }
        }
        return count-1;
    }   

}

class Program
{
    public static void Main(string[] args)
    {
        int g = Convert.ToInt32(Console.ReadLine().Trim());

        for (int gItr = 0; gItr < g; gItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int maxSum = Convert.ToInt32(firstMultipleInput[2]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            int result = Result.twoStacks(maxSum, a, b);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
