using System;
using System.Collections.Generic;

// We are given a matrix of strings of size N x M.
// Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix. 

namespace FindTheLongestSequence
{
    // Note from the author:

    // This task took me one day and a lot of debugging to cover all possible ways.
    // Can be done more simple as dividing the code to several methods, but then it will become even more incomprehensible.
    // The task is very difficult
    // I think that this version , even poor writtenable, satisfies the requirements of the task.
    // In the future, maybe I will fix code.
    // Whit uppercase letter in the matrix are founded combinations.
    // This is for better understanding.

    public class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = {
                                   {"BLA", "JM", "JM", "JM", "zmej"},
                                   {"BLA", "zmej", "JM", "br", "jm"},
                                   {"BLA", "zmej", "zmej", "JM", "jm"},
                                   {"BLA", "bla", "zmej", "jm", "JM"},
                                   {"BLA", "bla", "bla", "jm", "jm"}
                               };

            IterateMatrixByRows(matrix);  // by rows
            IterateMatrixByColls(matrix);  // by colls
            IterateMatrixByDiagonal(matrix); // by diagonal
        }

        static void IterateMatrixByRows(string[,] matrix)
        {
            int len = 1;
            int bestLen = 0;
            string start = null;
            string bestStart = "";
            List<string> myList = new List<string>();
            int endRow = matrix.GetLength(0);
            int endColl = matrix.GetLength(1);

            int coll = 0;

            while (coll != endColl)
            {
                for (int row = 0; row < endRow - 1; row++)
                {
                    if (matrix[row, coll] == matrix[row + 1, coll] && !myList.Contains(matrix[row, coll]))
                    {
                        len++;
                        start = matrix[row, coll];
                        myList.Add(matrix[row, coll]);
                    }
                    else if (matrix[row, coll] == matrix[row + 1, coll] || row == endRow)
                    {
                        len++;

                        if (len > bestLen)
                        {
                            bestLen = len;
                            bestStart = start;
                        }
                    }
                    else
                    {
                        len = 1;
                    }
                }
                coll++;
                len = 1;
            }

            PrintMatrix(bestLen, bestStart);
        }

        static void IterateMatrixByColls(string[,] matrix)
        {
            int len = 1;
            int bestLen = 0;
            string start = null;
            string bestStart = "";
            List<string> myList = new List<string>();
            int row = 0;
            int endRow = matrix.GetLength(0);
            int endColl = matrix.GetLength(1);

            while (row != endRow)
            {
                for (int coll = 0; coll < endColl - 1; coll++)
                {
                    if (matrix[row, coll] == matrix[row, coll + 1] && !myList.Contains(matrix[row, coll]))
                    {
                        len++;
                        start = matrix[row, coll];
                        myList.Add(matrix[row, coll]);
                    }
                    else if (matrix[row, coll] == matrix[row, coll + 1])
                    {
                        len++;

                        if (len > bestLen)
                        {
                            bestLen = len;
                            bestStart = start;
                        }
                    }
                    else
                    {
                        len = 1;
                    }
                }
                row++;
                len = 1;
            }

            PrintMatrix(bestLen, bestStart);
        }

        static void IterateMatrixByDiagonal(string[,] matrix)
        {
            int len = 1;
            int bestLen = 0;
            string start = null;
            string bestStart = "";
            List<string> myList = new List<string>();

            int row = 0;
            int coll = 0;
            int count = 0;
            int endRow = matrix.GetLength(0);
            int endColl = matrix.GetLength(1);
            int num = 0;
           
            // iterate on diagonals increasing columns
            while (count != endColl - 1)
            {
                while(num != endColl - count - 1)
                {
                    if (matrix[row, coll] == matrix[row + 1, coll + 1]
                        && !myList.Contains(matrix[row, coll]) || row == endRow - 1)
                    {
                        len++;
                        start = matrix[row, coll];
                        myList.Add(matrix[row, coll]);

                        if (len > bestLen)
                        {
                            bestLen = len;
                            bestStart = start;
                        }
                    }
                    else if (matrix[row, coll] == matrix[row + 1, coll + 1] && !myList.Contains(matrix[row, coll]))
                    {
                        len++;
                        start = matrix[row, coll];
                        myList.Add(matrix[row, coll]);
                    }
                    else if (matrix[row, coll] == matrix[row + 1, coll + 1])
                    {
                        len++;

                        if (len > bestLen)
                        {
                            bestLen = len;
                            bestStart = start;
                        }
                    }
                    else
                    {
                        len = 1;
                    }
                    row++;
                    coll++;
                    num++;
                }
                count++;
                row = 0;
                coll = count;
                len = 1;
                num = 0;
            }

            row = 1;
            coll = 0;
            count = 0;
            myList.Clear();

            // iterate on diagonals increasing rows
            while (count != endRow - 1)
            {
                while(row != endRow - 1)
                {
                    if (matrix[row, coll] == matrix[row + 1, coll + 1]
                        && !myList.Contains(matrix[row, coll]) || row == endRow - 1)
                    {
                        len++;
                        start = matrix[row, coll];
                        myList.Add(matrix[row, coll]);

                        if (len > bestLen)
                        {
                            bestLen = len;
                            bestStart = start;
                        }
                    }
                    else if (matrix[row, coll] == matrix[row + 1, coll + 1] && !myList.Contains(matrix[row, coll]))
                    {
                        len++;
                        start = matrix[row, coll];
                        myList.Add(matrix[row, coll]);
                    }
                    else if (matrix[row, coll] == matrix[row + 1, coll + 1])
                    {
                        len++;

                        if (len > bestLen)
                        {
                            bestLen = len;
                            bestStart = start;
                        }
                    }
                    else
                    {
                        len = 1;
                    }
                    row++;
                    coll++;
                }
                count++;
                row = count;
                coll = 0;
                len = 1;
            }

            PrintMatrix(bestLen, bestStart);
        }

        static void PrintMatrix(int bestLen, string bestStart) // Method for print the matrix
        {
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(bestStart + " ");
            }
            Console.WriteLine();
        }
    }
}
