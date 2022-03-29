using System;

namespace ArrayAdditionByOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] {8, 8};

            for (int count = number.Length -1 ; count >= 0; count--)
            {
                if (number[count] == 9)
                {
                    number[count] = 0;
                }
                else
                {
                    number[count] = number[count] + 1;
                    break;
                }

                if (number[0] == 0)
                {
                    Array.Resize(ref number, number.Length);
                    number[0] = 1;
                }
            }

            Array.ForEach(number, Console.WriteLine);
            Console.ReadLine();
        }
    }
}
