using System;

// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3
// that has maximal sum of its elements.

namespace MaximalSum3x3
{
    public class Program
    {
        static void Main()
        {
            int[,] matrix = {
                                {3, 5, 6, -5, 7},
                                {1, 7, 6, 12, -3},
                                {2, 5, 1, -4, 5}
                            };

            int bestSum = FindBestSumOfMatrixSquare3x3(matrix);

            Console.WriteLine("The best sum is {0}.", bestSum);
        }

        private static int FindBestSumOfMatrixSquare3x3(int[,] matrix)
        {
            int bestSum = 0;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[1, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                    sum = 0;
                }
            }

            return bestSum;
        }
    }
}