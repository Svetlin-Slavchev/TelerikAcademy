using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum 
// of its elements.

class FindMaximalSum
{
    static void Main(string[] args)
    {
        int[,] matrix = {
        {2, 4, 1, 8, 9},
        {3, 9,-1, 5, 4},
        {6, 1, 0,-6, 3},
        {5,-2, 5, 6, 7} };

        int platformMaxX = 3;
        int platformMaxY = 3;
        int maxSum = int.MinValue;

        for (int i = 0; i < matrix.GetLongLength(0) - (platformMaxX - 1); i++)
        {
            for (int j = 0; j < matrix.GetLongLength(1) - (platformMaxY - 1); j++)
            {
                int curentSum = 0;

                // Iterate all platforms for X and Y
                for ( int platformX = i; platformX < platformMaxX + i; platformX++)
                {
                    for ( int platformY = j; platformY < platformMaxY + j; platformY++)
                    {
                        curentSum += matrix[platformX, platformY];
                    }
                }
                // Find best platform
                if (curentSum > maxSum)
                {
                    maxSum = curentSum;
                }
            }
        }

        Console.WriteLine(maxSum);
    }
}
