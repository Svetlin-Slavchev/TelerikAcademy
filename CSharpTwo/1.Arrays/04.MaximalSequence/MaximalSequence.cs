using System;
using System.Collections.Generic;

// Write a program that finds the maximal sequence of equal elements in an array.
//	Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.


class Program
{
    static void Main(string[] args)
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        //int n = int.Parse(Console.ReadLine());
        // int[] array = new int[n];

        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        int bestStart = 0;
        int bestLen = 1;
        int start = 0;
        int len = 1;
        
        for (int i = 0; i < array.Length - 1; i++)
        {

            if (array[i] == array[i + 1])
            {
                start = array[i];
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
        Console.WriteLine("The number of maximal sequence is {0} with lenght {1}", bestStart, bestLen);
    }
}


