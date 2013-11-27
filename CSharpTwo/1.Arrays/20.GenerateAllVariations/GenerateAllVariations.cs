using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

class CombinationsGenerator
{
    static void Main()
    {
        int n = 2;  // number for K
        int startNum = 1;
        int endNum = 6;  // number for N
        //int n = int.Parse(Console.ReadLine());
        //int startNum = int.Parse(Console.ReadLine());
        //int endNum = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        GenerateCombinations(arr, 0, startNum, endNum);
    }

    static void GenerateCombinations(int[] arr, int index, int startNum, int endNum)
    {
        if (index >= arr.Length)
        {
            Console.WriteLine("(" + String.Join(", ", arr) + ")");
        }
        else
        {
            for (int i = startNum; i <= endNum; i++)
            {
                arr[index] = i;
                GenerateCombinations(arr, index + 1, i, endNum);
            }
        }
    }
}



