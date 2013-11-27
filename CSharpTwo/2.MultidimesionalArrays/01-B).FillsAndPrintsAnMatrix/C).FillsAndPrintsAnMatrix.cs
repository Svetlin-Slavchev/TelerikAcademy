using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

class FillsAndPrintsAnMatrix
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int colls = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, colls];
        FillMatrix(matrix, rows, colls);
        PrintMatrix(matrix, rows, colls);
    }
    static int[,] FillMatrix(int[,] matrix, int rows, int colls)   // Method for solving the problem
    {
        string direction = "down";
        int curentRow = rows - 1;
        int curentColl = 0;
        int endRow = rows - 1;
        int endColl = colls - 1;
        int count = 1;
        int countWhile = 1;
        int countWhileTwo = 1;

        do
        {
            while (curentRow <= endRow)                    // Print half-size diagonal of matrix in ascending order
            {
                matrix[curentRow, curentColl] = count;
                count++;

                if (curentRow != endRow)
                {
                    curentColl++;
                }
                curentRow++;
            }
            countWhile++;
            curentRow = curentRow - countWhile;
            curentColl = 0;

            if (curentRow < 0)    // Print other diagonals in descending order
            {
                curentRow++;
                curentColl++;
                while (count <= rows * colls)
                {
                    while (curentColl <= endColl)
                    {
                        matrix[curentRow, curentColl] = count;
                        count++;
                        curentRow++;
                        curentColl++;
                    }
                    countWhileTwo++;
                    curentRow = 0;
                    curentColl = countWhileTwo;
                }
            }
        } while (count <= rows * colls);

        return matrix;
    }

    static void PrintMatrix(int[,] matrix, int rows, int colls)   // Method for print the matrix
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colls; j++)
            {
                Console.Write(matrix[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
}


