using System;

namespace PrintPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine().Trim());

            PrintSquare(num);
            PrintPattern_1(num);
            PrintPattern_2(num);
            PrintPattern_3(num);
            PrintPattern_4(num);
            PrintTriangle(num);
            PrintInvertedTriangle(num);
            PrintDiamond(num);
            PrintNumberPatter_1(num);
            PrintNumberPatter_2(num);
            PrintNumberPatter_3(num);
            // PrintCircle(num);

            Console.ReadLine();
        }

        private static void PrintCircle(int num)
        {

        }

        private static void PrintPattern_1(int num)
        {
            // # 
            // # #
            // # # #

            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void PrintPattern_2(int num)
        {
            // # # #
            // # #
            // #

            for (int row = 1; row <= num; row++)
            {
                for (int col = num; col >= row; col--)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void PrintPattern_3(int num)
        {
            // # # #
            //   # #
            //     #

            for (int row = 1; row <= num; row++)
            {
                for (int space = 1; space < row; space++)
                {
                    Console.Write("  ");
                }
                for (int col = num; col >= row; col--)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void PrintPattern_4(int num)
        {
            //     #
            //   # #
            // # # #

            for (int row = 1; row <= num; row++)
            {
                for (int space = 1; space <= (num - row ); space++)
                {
                    Console.Write("  ");
                }
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void PrintTriangle(int num)
        {
            //   #
            //  # #
            // # # #
            for (int row = 1; row <= num; row++)
            {
                for (int space = 1; space <= (num - row); space++)
                {
                    Console.Write(" ");
                }

                for (int col = 1; col <= row; col++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void PrintInvertedTriangle(int num)
        {
            // # # #
            //  # #
            //   #
            for (int row = 1; row <= num; row++)
            {
                for (int space = 1; space < row; space++)
                {
                    Console.Write(" ");
                }

                for (int col = num; col >= row; col--)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void PrintDiamond(int num)
        {
            //   #
            //  # #
            // # # #
            //  # #
            //   #
            for (int row = 1; row < num; row++)
            {
                for (int space = 1; space <= (num - row); space++)
                {
                    Console.Write(" ");
                }

                for (int col = 1; col <= row; col++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            for (int row = 1; row <= num; row++)
            {
                for (int space = 1; space < row; space++)
                {
                    Console.Write(" ");
                }

                for (int col = num; col >= row; col--)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintNumberPatter_1(int num)
        {
            // 1
            // 2 2 
            // 3 3 3
            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("{0} ", row);
                }
                Console.WriteLine();
            }
        }

        private static void PrintNumberPatter_2(int num)
        {
            // 1
            // 1 2 
            // 1 2 3
            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("{0} ", col);
                }
                Console.WriteLine();
            }
        }

        private static void PrintNumberPatter_3(int num)
        {
            for (int row = 1, count = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++, count++)
                {
                    Console.Write("{0}  ", count);
                }
                Console.WriteLine();
            }
        }

        private static void PrintSquare(int num)
        {
            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
