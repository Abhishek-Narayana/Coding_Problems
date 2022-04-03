using System;

namespace TravelArrayInCirculerFashion
{
    class Program
    {
        public static int[,] matrix;
        static void Main(string[] args)
        {
            GenerateMatrix(10);
            TravelArrayInCirculerFashion();
            Console.ReadLine();
        }

        private static void GenerateMatrix(int number)
        {
            matrix = new int[number, number];
            for (int count = 1, row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    matrix[row, col] = count++;
                }
            }
        }

        private static void TravelArrayInCirculerFashion()
        {
            int numberOfItemToPrint = matrix.GetLength(0);
            int row = 0, col = 0;
            for (int count = 0; count <= matrix.GetLength(0) / 2; count++)
            {
                // print left to right 
                int numberOfItemPrinted = 0;
                while (numberOfItemPrinted < numberOfItemToPrint)
                {
                    Console.Write(matrix[row, col++] + " ");
                    numberOfItemPrinted++;
                }

                // let's break after printing the center element
                if(numberOfItemToPrint == 1 )
                    break;
                
                numberOfItemToPrint--;
                col--;
                row++;

                // printing top to buttom
                numberOfItemPrinted = 0;
                while (numberOfItemPrinted < numberOfItemToPrint)
                {
                    Console.Write(matrix[row++, col] + " ");
                    numberOfItemPrinted++;
                }
                row--;
                col--;

                // printing right to left
                numberOfItemPrinted = 0;
                while (numberOfItemPrinted < numberOfItemToPrint)
                {
                    Console.Write(matrix[row, col--] + " ");
                    numberOfItemPrinted++;
                }
                numberOfItemToPrint--;
                col++;
                row--;

                // printing buttom to top
                numberOfItemPrinted = 0;
                while (numberOfItemPrinted < numberOfItemToPrint)
                {
                    Console.Write(matrix[row--, col] + " ");
                    numberOfItemPrinted++;
                }
                numberOfItemPrinted = 0;
                col++;
                row++;
            }
        }
    }
}
