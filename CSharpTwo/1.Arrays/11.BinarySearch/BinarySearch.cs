using System;

// Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm.

class BinarySearch
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());     // Array size.
        int index = int.Parse(Console.ReadLine());    // Number of elementс thah we are looking for.
                                                      // Must be a number less then n.
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);       // Sort array - it is necessarry.
        
        int indexMin = 0;
        int indexMax = array.Length - 1;
        int indexMid = 0;

        while(indexMid != index)            // Find indexMid == index.
        {
            if (index > array[indexMid])
            {
                indexMin = indexMid + 1;
            }
            else
            {
                indexMax = indexMid - 1;
            }
            indexMid = indexMin + indexMax / 2;
        }
    
        Console.WriteLine("We are looking for element[{0}] = {1}", indexMid, array[indexMid]);
    }
}

