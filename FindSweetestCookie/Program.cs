using System.Collections.Generic;
using System;

namespace FindSweetestCookie
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> A = new List<int>() { 1, 1, 1 };
            int result = Result.cookies(10, A);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}


class Result
{
    public static int cookies(int k, List<int> A)
    {   
        if(A == null)
            return -1;

        int TotolNumberOfOperation = 0;
        A.Sort();
        if(A.Count > 1)
        {

            while (A[0] < k) 
            {
                if(A.Count == 1 && A[0] < k)
                {
                    return -1;
                }
                int newCookie = A[0] + (A[1] * 2);
                A.RemoveAt(0);
                A.RemoveAt(0);
                TotolNumberOfOperation++;
                InsertInSortedList(A, newCookie);
            }
        }
        return TotolNumberOfOperation;
    }

    private static void InsertInSortedList(List<int> list, int num)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if(list[i] > num)
            {
                list.Insert(i, num);
                return;
            }
        }
        list.Add(num);
        return;
    }
}


