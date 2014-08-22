using System;
using SelectionSortAlgorithm;

// Write a program that finds the index of given element in a sorted array of integers
// by using the binary search algorithm (find it in Wikipedia).

namespace BinarySearch
{
    public class Program
    {
        public static int BinarySearch(int[] arr, int value)
        {
            int start = 0; // start point of arr
            int end = arr.Length; // end point of arr
            int middle;

            while (start <= end)
            {
                middle = (start + end) / 2;
                //the element we search is to the right from the middle
                if (arr[middle] < value)
                {
                    start = middle + 1;
                    continue;
                }
                //the element we search is to the left from the middle
                else if (arr[middle] > value)
                {
                    end = middle - 1;
                    continue;
                }
                // find the index of searhing value
                else
                {
                    return middle;
                }
            }
            //if value not found
            return -1;
        }

        static void Main()
        {
            int[] arr = { 2, 1, 6, 2, 5, 3 };

            // invoke SelectionSort method from task 7 in this homework
            // To implement BinarySearch array must be sorted
            SelectionSortAlgorithm.Program.SelectionSort(arr);

            int value = 5; // or use Console.ReadLine()
            int result = BinarySearch(arr, value);

            if (result != -1)
            {
                Console.WriteLine("Index of searching value is {0}.", result);
            }
            else
            {
                Console.WriteLine("Value not found!");
            }          
        }
    }
}
