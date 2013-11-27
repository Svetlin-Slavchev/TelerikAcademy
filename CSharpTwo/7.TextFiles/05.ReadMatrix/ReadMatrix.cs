using System;
using System.IO;
using System.Linq;

// Write a program that reads a text file containing a square matrix of numbers
// and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
// The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space.\
// The output should be a single number in a separate text file. Example:
//  4
//  2 3 3 4
//  0 2 3 4		->	17
//  3 7 1 2
//  4 3 3 2

class ReadMatrix
{
    static int dimention;
    static int[,] matrix;
    static int bestSum;

    static void Main(string[] args)
    {
        string textFile = @"text.txt";
        InitializationMatrix(textFile);
        BestSum(matrix, dimention);

        using (StreamWriter writer = new StreamWriter("secondText.txt"))
        {
            writer.Write(bestSum);
        }
        // Only for testing !!!
        using (StreamReader reader = new StreamReader("secondText.txt"))
        {
            Console.WriteLine(reader.ReadLine());
        }
    }

    static int[,] InitializationMatrix(string textFile)
    {
        using (StreamReader reader = new StreamReader(textFile))
        {
            dimention = int.Parse(reader.ReadLine());
            string line = reader.ReadLine();
            string[] splitLine = (line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            matrix = new int[dimention, dimention];
            for (int i = 0; i < dimention; i++)
            {
                for (int j = 0; j < dimention; j++)
                {
                    //Console.Write(matrix[i, j] = int.Parse(splitLine[j]));
                    matrix[i, j] = int.Parse(splitLine[j]);
                }

                // Console.WriteLine();
                line = reader.ReadLine();
                if (line != null)
                {
                    splitLine = (line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                }
            } 
            return matrix;
        } 
    }

    static int BestSum(int[,] matrix, int dimention)
    {
        int sum = 0;
        bestSum = int.MinValue;
        for (int i = 0; i < dimention - 1; i++)
        {
            for (int j = 0; j < dimention - 1; j++)
            {
                sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }
        return bestSum;
    }
}
