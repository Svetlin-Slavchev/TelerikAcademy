using System;

// Write a program that finds the most frequent number in an array.
 // Example:{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

class TheMostFrequentNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        
        int bestCount = 0;
        int bestNumber = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int number = array[i];
            int count = 0;
            
            for (int j = 0; j < array.Length; j++)
            {
                if (number == array[j])
                {
                    count++;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestNumber = number;
                }
            }
        }
        Console.WriteLine("The most frequent number in the array is {0} and repeated {1} times", bestNumber, bestCount);
    }
}

