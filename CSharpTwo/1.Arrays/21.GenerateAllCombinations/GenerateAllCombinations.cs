using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
//Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

class CombinationsGenerator
{
    static void Main()
    {
        int n = 3;  // number for K
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
                GenerateCombinations(arr, index + 1 , i + 1, endNum);
            }
        }
    }
}


