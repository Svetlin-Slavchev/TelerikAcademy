using System;
using System.Collections.Generic;

// * Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
// Find in the array a subset of K elements that have sum S or indicate about its absence.

namespace FindASubsetOfElementsThatHaveSpecificSum
{
    public class sorting
    {
        static void Main()
        {
            int arrayNumbers = 4; // N
            int[] arr = { 2, 1, 2, 3 }; // int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int sum = 4; // 14 // S
            int numberOfElements = 2; // 4 // K

            List<int> mylist = new List<int>();
            // max number of posible subset
            int maxSubset = (int)Math.Pow(2, arrayNumbers) - 1;
            int currentSum = 0;
            int count = 0;

            for (int i = 1; i <= maxSubset; i++)
            {
                currentSum = 0;
                for (int j = 1; j <= arr.Length; j++)
                {
                    if (((i >> (j - 1)) & 1) == 1)
                    {
                        currentSum += arr[j - 1];
                        mylist.Add(arr[j - 1]);
                    }
                }

                if (currentSum == sum)
                {
                    count++;

                    if (mylist.Count == numberOfElements)
                    {
                        for (int m = 0; m < mylist.Count; m++)
                        {
                            Console.Write(mylist[m] + " ");
                        }
                        Console.WriteLine();
                    }                                    
                }

                mylist.Clear();
            }
            if (count == 0)
            {
                Console.WriteLine("There is no subset equal to {0}", sum);
            }
        }
    }
}

