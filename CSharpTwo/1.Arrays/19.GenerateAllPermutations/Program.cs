﻿using System;

// * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
// Example: n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

namespace GenerateAllPermutations
{
    public class Program
    {
        static void Check(int[] arr)
        {
            Console.Write("(");
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.Write(arr[i] + 1 + (i == arr.Length - 1 ? "\n" : " "));
                Console.Write(arr[i] + 1 + (i == arr.Length - 1 ? "" : " "));
            }
            Console.Write(")");
            Console.WriteLine();
        }

        static void Permutation(int[] arr, bool[] used, int i)
        {
            if (i == arr.Length)
            {
                Check(arr);
                return;
            }

            for (int j = 0; j < arr.Length; j++)
            {
                if (used[j])
                {
                    continue;
                }

                arr[i] = j;

                used[j] = true;
                Permutation(arr, used, i + 1);
                used[j] = false;
            }
        }

        static void Main()
        {
            int[] arr = new int[3];
            //int[] arr = new int[int.Parse(Console.ReadLine())];

            bool[] used = new bool[arr.Length];
            Permutation(arr, used, 0);
        }
    }
}
