using System;
using System.Collections.Generic;
using System.Linq;

//We are given a matrix of strings of size N x M.
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. 

class Program
{
    static void Main(string[] args)
    {
        string[,] matrix ={ 
                   {"ala", "ala", "ala"},
                   {"bala", "port", "vala"},
                   {"bala", "mala", "port"}};
        IterateMatrixByRows(matrix, 3, 3);         // Will print bigest sequence by rows
        IterateMatrixByColls(matrix, 3, 3);        // ..... by colls
        IterateMatrixByDiagonal(matrix, 3, 3);     //  ...... by diagonal
    }
    static string[,] IterateMatrixByRows(string[,] matrix, int rows, int colls)   
    {
        int len = 1;
        int bestLen = 0;
        string start = null;
        string bestStart = "";  
        List<string> myList = new List<string>();   // In this List we will put all sequece and after second 'for'
                                                    // cicle we will clear the List.

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colls - 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1])
                {
                    myList.Add(matrix[i, j]);
                    len++;
                    start = matrix[i, j];
                }                
            }

            if (len > bestLen)           // With compare we select the best sequence and then we initialize with
                                          //  variable 'start'
                 
            {
                bestLen = len;
                bestStart = start;
            }
            start = null;
            myList.Clear();
        }

        PrintMatrix( matrix, rows, colls, bestLen, bestStart);
        return matrix;
    }

    static string[,] IterateMatrixByColls(string[,] matrix, int rows, int colls)  
    {
        int len = 1;
        int bestLen = 0;
        string start = null;
        string bestStart = "";
        List<string> myList = new List<string>();

        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[i, j] == matrix[i + 1, j])
                {
                    myList.Add(matrix[i, j]);
                    len++;
                    start = matrix[i, j];
                }
            }

            if (len > bestLen)
            {
                bestLen = len;
                bestStart = start;
            }
            start = null;
            myList.Clear();
        }

        PrintMatrix(matrix, rows, colls, bestLen, bestStart);
        return matrix;
    }

    static string[,] IterateMatrixByDiagonal(string[,] matrix, int rows, int colls) 
    {
        int len = 1;
        int bestLen = 0;
        string start = null;
        string bestStart = "";
        List<string> myList = new List<string>();
        int endRow = rows - 1;
        int endColl = colls - 1;
        int count = 0;

        for (int i = 0; i < endRow; i++)
        {
            for (int j = 0; j < endColl; j++)
            {
                if (matrix[i, j] == matrix[i + 1, j + 1])
                {
                    myList.Add(matrix[i, j]);
                    len++;
                    start = matrix[i, j];
                }

            }
            if (len > bestLen)
            {
                bestLen = len;
                bestStart = start;
            }
            myList.Clear();
        } 

        PrintMatrix(matrix, rows, colls, bestLen, bestStart);
        return matrix;
    }

    static void PrintMatrix(string[,] matrix, int rows, int colls, int bestLen, string bestStart)   // Method for print the matrix
    {
        for (int i = 0; i < bestLen; i++)
        {
            Console.Write(bestStart + " ");
        }
        Console.WriteLine();
    }
}



