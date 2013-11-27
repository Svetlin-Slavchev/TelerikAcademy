using System;
using System.Linq;

// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

class FillsAndPrintsAnMatrix
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int colls = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, colls];
        PrintMatrix(matrix, rows, colls);
    }

    static void PrintMatrix(int[,] matrix, int rows, int colls)
    {
        for (int row = 0; row < matrix.GetLongLength(0); row++)
        {
            for (int coll = 0; coll < matrix.GetLength(1); coll++)
            {
                Console.Write((matrix[row, coll] = (row + coll * 4) + 1) + " ");
            }

            Console.WriteLine();
        }
    }
}


        






 