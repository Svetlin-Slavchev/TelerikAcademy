using System;

// Write a program that reads from a console positive integer number N (N < 20) and outputs a matrix[n,n].

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number for n: ");
        int n = int.Parse(Console.ReadLine());

        int rows = n;
        int cols = n;

        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < matrix.GetLength(0); row++)

        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = row + col + 1;
                Console.Write("{0}", matrix[row, col]);
            }
            Console.WriteLine();

        }

    }
}


