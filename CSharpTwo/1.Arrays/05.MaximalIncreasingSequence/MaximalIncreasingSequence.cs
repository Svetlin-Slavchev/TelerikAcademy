using System;
using System.Linq;

// Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        int[] array = { 3, 2, 3, 4, 2, 2, 4 };
       // int n = int.Parse(Console.ReadLine());
       // int[] array = new int[n];

       // for (int i = 0; i < array.Length; i++)
       // {
       //     array[i] = int.Parse(Console.ReadLine());
       // }
        int endIndex = 0;
        int bestLen = 0;
        int len = 1;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                len++;
                if (i + 1 == array.Length)
                {
                    endIndex = i + 1;
                    len++;
                }
            }
            else
            {
                if (len > bestLen)
                {
                    bestLen = len;
                    endIndex = i;
                }
                len = 1;
            }
        }
        if (len > bestLen)
        {
            bestLen = len;
            endIndex = array.Length - 1;
        }
        Console.WriteLine("The maximal increasing sequence is: ");
        for (int k = endIndex - bestLen + 1; k < endIndex + 1; k++)
        {
            Console.Write(array[k] + " ");
        }
    }
}





