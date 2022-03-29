using System;
using System.Collections;

namespace ParenthesisBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckParenthesisBalance("((()"));
            Console.ReadLine();
        }

        // 1 => 1
        // 2 => 2
        // 3 => 3
        // 4 => 4

        public int Fact(int n)
        {
            if (n <= 0) 
                return 0;
            else if (n == 1) 
                return 1;
            return n * Fact(n - 1);
            // O(n)
        }

        private static bool CheckParenthesisBalance(string input)
        {
            
            if (string.IsNullOrEmpty(input) || input.Length % 2 != 0)
                return false;

            Stack stack = new Stack();
            foreach (char parenthes in input)
            {
                if(parenthes == ')' || parenthes == ']' || parenthes == '}')
                {
                    char previous = (char)stack.Peek();
                    switch (parenthes)
                    {
                        case ')':
                            if ('(' == previous)
                                stack.Pop();
                            else
                                return false;
                            break;
                        case ']':
                            if ('[' == previous)
                                stack.Pop();
                            else
                                return false;
                            break;
                        case '}':
                            if ('{' == previous)
                                stack.Pop();
                            else
                                return false;
                            break;
                        default:
                            return false;
                    }
                }
                else
                {
                    stack.Push(parenthes);
                }
            }

            return stack.Count == 0;
        }
    }
}
