using System;

namespace MatrixRotationby90Degree
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 2, col = 2;
            int[,] matrix = new int[row, col];

            // Generate matrix 
            for (int i = 0, count = 1; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = count++;
                }
            }

            RotateMatrixby90Degree(matrix);
            Console.ReadLine();
        }

        private static void RotateMatrixby90Degree(int[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            int[,] result = new int[rowLength, colLength];
            for (int m1_row = 0, m2_row = rowLength -1; m1_row < rowLength; m1_row++, m2_row--)
            {
                for (int m1_col = 0, m2_col = 0; m1_col < colLength; m1_col++, m2_col++)
                {
                    Console.Write(matrix[m1_col, m1_row]);
                    result[m1_col, m1_row] = matrix[m2_row, m2_col];
                }
                Console.WriteLine();
            }
        }
    }
}
