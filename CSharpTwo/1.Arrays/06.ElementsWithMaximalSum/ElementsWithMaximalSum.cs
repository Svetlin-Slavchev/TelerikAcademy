using System;

// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int sumElements = 0;
        int maximalSum = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            sumElements = array[i] + array[i + 1];

            if (sumElements > maximalSum)
            {
                maximalSum = sumElements;
            }
        }
        Console.WriteLine("Maximal sum is: " + maximalSum);
    }
}

