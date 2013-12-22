using System;
using System.Collections.Generic;

// Write a program that finds in given array of integers a sequence of given sum S (if present).
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

namespace FindSequenceOfSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 11;
            int arrSum = 0;
            List<int> list = new List<int>();

            int[] arr = { 4, 3, 1, 4, 2, 5, 8 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0 + i; j < arr.Length; j++)
                {
                    arrSum += arr[j];
                    list.Add(arr[j]);

                    // check if arrSum == sum
                    if (arrSum == sum)
                    {                                              
                        var result = string.Join(", ", list);  
                        Console.Write("( {0} )", result);
                    }
                }
                // clearing variables for new iteration
                arrSum = 0;
                list.Clear();
            }
            Console.WriteLine();
        }
    }
}
