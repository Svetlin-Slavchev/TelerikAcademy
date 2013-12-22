using System;

// Write a program that finds the  in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
// Can you do it with only one loop (with single scan through the elements of the array)?

namespace SequenceOfMaximalSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, -6, 2, 5, -3 };

            int sumOfElements = 0;
            int bestSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    sumOfElements += arr[j];

                    if (sumOfElements > bestSum)
                    {
                        bestSum = sumOfElements;
                    }
                }
                // reset sum
                sumOfElements = 0;
            }

            Console.WriteLine("Maximal sum is {0}.", bestSum);
        }
    }
}
