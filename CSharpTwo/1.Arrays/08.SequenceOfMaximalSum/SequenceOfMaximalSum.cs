using System;

// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int sumElements = 0;
        int maximalSum = 0;
        for (int k = - 1; k < array.Length; k++)
        {
            for (int j = k + 1; j < array.Length; j++)
            {
                sumElements += array[j];

                if (sumElements > maximalSum)
                {
                    maximalSum = sumElements;
                }
            }
            sumElements = 0;
        }
        Console.WriteLine("Maximal sum is: " + maximalSum);
    }
}


