using System;

// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

namespace PrintMatrix
{
    public class Program
    {
        static void Main()
        {
            int[,] matrix = new int[4, 4];

            Console.WriteLine("Matrix A");
            SetMatrixToDownOnRows(matrix);
            PrintMatrix(matrix);

            Console.WriteLine("\nMatrix B");
            SetMatrixFromTopToBottomInRows(matrix);
            PrintMatrix(matrix);

            Console.WriteLine("\nMatrix C");
            SetDiagonalMatrix(matrix);
            PrintMatrix(matrix);

            Console.WriteLine("\nMatrix D");
            SetSpiralMatrix(matrix);
            PrintMatrix(matrix);
        }

        // method for inicialize matrix A
        public static int[,] SetMatrixToDownOnRows(int[,] matrix)
        {
            int count = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // replace i and j
                    matrix[j, i] = count;
                    count++;
                }
            }

            return matrix;
        }

        // method for inicialize matrix B
        public static int[,] SetMatrixFromTopToBottomInRows(int[,] matrix)
        {
            int count = 1;
            int colls = 0; // j
            string direction = "down";

            while (count != 17)
            {
                if (direction == "down")
                {
                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        matrix[rows, colls] = count;
                        count++;
                    }
                    // change direction and increase colls whit 1
                    direction = "up";
                    colls++;
                }

                if (direction == "up")
                {
                    for (int rows = matrix.GetLength(0) - 1; rows >= 0; rows--)
                    {
                        matrix[rows, colls] = count;
                        count++;
                    }
                    // change direction and increase colls whit 1
                    direction = "down";
                    colls++;
                }
            }

            return matrix;
        }

        // method for inicialize matrix C
        public static int[,] SetDiagonalMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0) - 1;
            int coll = 0;
            int endRow = matrix.GetLength(0) - 1;
            int endColl = matrix.GetLength(1) - 1;
            int count = 1;
            int countWhile = 1;
            int countWhileTwo = 1;

            do
            {
                while (row <= endRow) // Print half-size diagonal of matrix in ascending order
                {
                    matrix[row, coll] = count;
                    count++;

                    if (row != endRow)
                    {
                        coll++;
                    }
                    row++;
                }
                countWhile++;
                row = row - countWhile;
                coll = 0;

                if (row < 0) // Print other diagonals in descending order
                {
                    row++;
                    coll++;
                    while (count <= matrix.GetLength(0) * matrix.GetLength(0))
                    {
                        while (coll <= endColl)
                        {
                            matrix[row, coll] = count;
                            count++;
                            row++;
                            coll++;
                        }
                        countWhileTwo++;
                        row = 0;
                        coll = countWhileTwo;
                    }
                }

            } while (count <= matrix.GetLength(0) * matrix.GetLength(0));

            return matrix;
        }

        // method for inicialize matrix D
        public static int[,] SetSpiralMatrix(int[,] matrix)
        {
            bool[,] arr = new bool[4, 4]; 
            int count = 1;
            string direction = "down";
            int endRow = matrix.GetLength(0) - 1;
            int endColl = matrix.GetLength(1) - 1;
            int row = 0;
            int coll = 0;

            while (count != 17)
            {
                if (direction == "down")
                {
                    while (row != endRow + 1) 
                    {
                        if (arr[row, coll]) // if next element is 'true', break and change direction
                        {
                            break;
                        }
                        matrix[row, coll] = count;
                        arr[row, coll] = true; // mark as visited
                        count++;
                        row++;                     
                    }
                    row--;
                    coll++;
                    direction = "right";
                }                

                else if (direction == "right")
                {
                    while (coll != endColl + 1)
                    {
                        if (arr[row, coll])
                        {
                            break;
                        }
                        matrix[row, coll] = count;
                        arr[row, coll] = true;
                        count++;
                        coll++;
                    }
                    direction = "up";
                    row--;
                    coll--;
                }

                else if (direction == "up")
                {
                    while (row != -1)
                    {
                        if (arr[row, coll])
                        {
                            break;
                        }
                        matrix[row, coll] = count;
                        arr[row, coll] = true;
                        count++;
                        row--;
                    }
                    direction = "left";
                    row++;
                    coll--;
                }

                else if (direction == "left")
                {
                    while (coll != -1)
                    {
                        if (arr[row, coll])
                        {
                            break;
                        }
                        matrix[row, coll] = count;
                        arr[row, coll] = true;
                        count++;
                        coll--;
                    }
                    direction = "down";
                    row++;
                    coll++;
                }
            }

            return matrix;
        }

        // method for printing matrix on the console
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
