using System;

// Sorting an array means to arrange its elements in increasing order.
// Write a program to sort an array. Use the "selection sort" algorithm:
// Find the smallest element, move it at the first position, find the smallest from the rest,
// move it at the second position, etc.

namespace SelectionSortAlgorithm
{
    public class Program
    {
        // method for sorting
        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i; j < arr.Length; j++)
                {
                    // find lowest element
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                // move lowest element to i position
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            return arr;
        }

        // method for printing array
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 6, 2, 5, 3 };

            SelectionSort(arr);

            //print result
            PrintArray(arr);
        }
    }
}
