using System;
using System.Collections.Generic;

namespace Tree_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int levelCounter = 0;
            Console.WriteLine("Hello World!");
            Print_Highest_Tree_Level(10, ref levelCounter);
            Console.WriteLine("Highest level is: {0}", levelCounter);
        }

        public static void Print_Highest_Tree_Level(int InputNumber, ref int levelCounter)
        {
            List<int> tree = new List<int>();

            //  Find all divisor for the given number
            for (int counter = 2; counter < InputNumber - 1; counter++)
            {
                if(InputNumber % counter == 0)
                {
                    tree.Add(counter);
                    // Call recursively
                    levelCounter++;
                    Print_Highest_Tree_Level(counter, ref levelCounter);
                }
            }

            // Add each divisor to the parent node

            // Console.WriteLine("Highest level is: {0}",levelCounter);
            // Print the branch with highest edges
        }
    }
}
