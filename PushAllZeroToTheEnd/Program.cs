using System;
using System.Collections.Generic;

namespace PushAllZeroToTheEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>() {2, 0, 1, 4, 0, 5, 6, 1 , 0 };
            PushAllZeroToTheEnd(ref number);
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static void PushAllZeroToTheEnd(ref List<int> number)
        {
            int ZeroCount = 0;
            for (int index = 0; index < number.Count; index++)
            {
                if(number[index] == 0 )
                {
                    number.RemoveAt(index);
                    ZeroCount++;
                }
            }
            for (int i = 0; i < ZeroCount; i++)
            {
                number.Add(0);
            }
        }
    }
}
