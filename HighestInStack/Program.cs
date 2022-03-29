using System.Collections.Generic;
using System.Collections;
using System.IO;
using System;
namespace HighestInStack
{
    class Result
    {
        public static List<int> getMax(List<string> operations)
        {
            List<int> highestList = new List<int>();
            Stack stack = new Stack();
            Stack maxStack = new Stack();
            foreach (string operation in operations)
            {
                switch (operation[0])
                {
                    case '1':
                        int newData = Convert.ToInt32(operation.Substring(2));
                        stack.Push(newData);
                        if (maxStack.Count > 0)
                        {
                            int topData = Convert.ToInt32(maxStack.Peek());
                            if (topData < newData)
                                maxStack.Push(newData);
                            else
                                maxStack.Push(topData);
                        }
                        else
                            maxStack.Push(newData);
                        break;

                    case '2':
                        stack.Pop();
                        maxStack.Pop();
                        break;

                    case '3':
                        highestList.Add(Convert.ToInt32(maxStack.Peek()));
                        break;
                }
            }
            return highestList;
        }

    }

    /// <summary>
    /// refer this page for problem statement : https://www.hackerrank.com/challenges/maximum-element/problem
    /// </summary>
    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> ops = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string opsItem = Console.ReadLine();
                ops.Add(opsItem);
            }

            List<int> res = Result.getMax(ops);

            Console.WriteLine(String.Join("\n", res));
            Console.ReadLine();
        }
    }
}
