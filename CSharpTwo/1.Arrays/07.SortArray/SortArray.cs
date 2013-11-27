using System;

// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
// Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
// find the smallest from the rest, move it at the second position, etc.

class Program
{
    static void Main(string[] args)
    {
       // int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];

       // for (int i = 0; i < n; i++)
       // {
      //      array[i] = int.Parse(Console.ReadLine());
       // }
        int[] array = {2, 5, 1, -2, 4};
        Console.WriteLine("The array before Selection Sort is: ");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("array[{0}] = {1}", i, array[i]);
        }

        for (int j = 0; j < array.Length - 1; j++)
        {
            int minKey = j;

            for (int k = j + 1; k < array.Length; k++)
            {
                if (array[k] < array[minKey])
                {
                    minKey = k;
                }
            }

            int tmp = array[minKey];
            array[minKey] = array[j];
            array[j] = tmp;
        }

        Console.WriteLine("The array after Selection Sort is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("array[{0}] = {1}", i, array[i]);
        }
    }
}

