using System;
using System.IO;

// Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2
// with a maximal sum of its elements. The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file.
// Example:
// 4
// 2 3 3 4
// 0 2 3 4		-->	17
// 3 7 1 2
// 4 3 3 2

namespace Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstFile = "matrix.txt";
            string secondFile = "result.txt";
            // read matrix
            int[,] matrix = ReadAndCreatMatrixFromTextFile(firstFile);
            // find best sum
            int bestSum = FindBest2x2SumInMatrix(matrix);
            // write result in secont file, read it and print it for test
            WriteAndReadResultFromSecondFile(secondFile, bestSum);           
        }

        private static void WriteAndReadResultFromSecondFile(string secondFile, int bestSum)
        {
            using (StreamWriter writer = new StreamWriter(secondFile))
            {
                writer.WriteLine(bestSum);
            }

            using (StreamReader reader = new StreamReader(secondFile))
            {
                Console.WriteLine(reader.ReadLine());
            }
        }

        private static int FindBest2x2SumInMatrix(int[,] matrix)
        {
            int curentSum = 0;
            int bestSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    curentSum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if (curentSum > bestSum)
                    {
                        bestSum = curentSum;
                    }
                    curentSum = 0;
                }
            }

            return bestSum;
        }

        private static int[,] ReadAndCreatMatrixFromTextFile(string firstFile)
        {
            using (StreamReader reader = new StreamReader(firstFile))
            {
                int dimention = int.Parse(reader.ReadLine());
                int[,] matrix = new int[dimention, dimention];
                string line = reader.ReadLine();

                int row = 0;
                int coll = 0;

                while (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        // if char is digit
                        if (char.IsDigit(line[i]))
                        {
                            matrix[row, coll] = int.Parse(line[i].ToString());
                            coll++;
                        }
                    }

                    row++;
                    coll = 0;
                    line = reader.ReadLine();
                }

                return matrix;
            }            
        }
    }
}
