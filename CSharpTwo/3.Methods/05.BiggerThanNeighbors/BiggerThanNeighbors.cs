using System;
using System.Linq;

// Write a method that checks if the element at given position in given array of integers is bigger 
// than its two neighbors (when such exist).

class BiggerThanNeighbors
{
    static void Main(string[] args)
    {
        int[] array = { 1, 3, 4, 5, 8, 3, 4, 5 };
        int bigestNumber = FindBiggerThanNeigborsInArray(array);
        PrintResult(bigestNumber);
    }

    static int FindBiggerThanNeigborsInArray(int[] array)
    {
        int bigNumber = int.MinValue;
        int bigestNumber = int.MinValue;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (i == 0)
            {
                if (array[i] > array[i + 1])
                {
                    bigNumber = array[i];
                }
            }
            else if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                bigNumber = array[i];
                if (bigNumber > bigestNumber)
                {
                    bigestNumber = bigNumber;
                }    
            } 
        }
        return bigestNumber;
    }

    static void PrintResult(int bigestNumber)
    {
        if (bigestNumber == int.MinValue)
        {
            Console.WriteLine("There is no such a number!");
        }
        else
        {
            Console.WriteLine("The biggest number in this array is {0}.", bigestNumber);
        }   
    }
}
