using System;
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
    static int[,] FillMatrix(int[,] matrix, int rows, int colls)
    {
        string direction = "down";
        int curentRow = 0;
        int curentColl = 0;
        int endRow = rows - 1;
        int endColl = colls - 1;

        for (int i = 1; i <= rows * colls; i++)
        {
            if (direction == "down")
            {
                matrix[curentRow, curentColl] = i;
                curentRow++;
                // check if the next number is not out of the array or the next position is not equal to 0 (not filled)
                if ((curentRow == endRow + 1) || (matrix[curentRow, curentColl] != 0))  
                {
                    direction = "right";
                    curentColl++;
                    curentRow--;
                    continue;
                }
            }

            if (direction == "right")
            {
                matrix[curentRow, curentColl] = i;
                curentColl++;
                if ((curentColl == endColl + 1) || (matrix[curentRow, curentColl] != 0))
                {
                    direction = "up";
                    curentColl--;
                    curentRow--;
                    continue;
                }
            }

            if (direction == "up")
            {
                matrix[curentRow, curentColl] = i;
                curentRow--;
                if ((curentRow < 0) || (matrix[curentRow, curentColl] != 0))
                {
                    direction = "left";
                    curentColl--;
                    curentRow++;
                    continue;
                }
            }

            if (direction == "left")
            {
                matrix[curentRow, curentColl] = i;
                curentColl--;
                if ((curentColl < 0) || (matrix[curentRow, curentColl] != 0))
                {
                    direction = "down";
                    curentColl++;
                    curentRow++;
                    continue;
                }
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix, int rows, int colls)
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



