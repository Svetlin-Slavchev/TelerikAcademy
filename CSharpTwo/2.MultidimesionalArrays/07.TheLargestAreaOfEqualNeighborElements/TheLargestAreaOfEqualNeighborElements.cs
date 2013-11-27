using System;

//* Write a program that finds the largest area of equal neighbor elements in
//a rectangular matrix and prints its size.

class DepthFirstSearchLargestArea
{
    static int[,] matrix =
            {
                {1,3,2,2,2,3},
                {3,3,3,2,4,1},
                {4,3,1,2,3,3},
                {4,3,1,3,3,1},
                {4,3,3,3,1,1},
            };
    static bool[,] checkedCells = new bool[matrix.GetLength(0), matrix.GetLength(1)];


    static int DepthFirstSearch(int row, int col, int value)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        {
            return 0;
        }

        if (checkedCells[row, col] == true)
        {
            return 0;
        }

        if (matrix[row, col] != value)
        {
            return 0;
        }

        checkedCells[row, col] = true;

        return DepthFirstSearch(row, col + 1, value) + DepthFirstSearch(row, col - 1, value) +
               DepthFirstSearch(row + 1, col, value) + DepthFirstSearch(row - 1, col, value) + 1;
    }

    static void Main()
    {
        int result = -1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result = Math.Max(result, DepthFirstSearch(row, col, matrix[row, col]));
            }
        }

        Console.WriteLine(result);
    }
}

