using System;
using System.Collections.Generic;

// * Write a program that reads an array of integers and removes from it a minimal number of elements in such way
// that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
//	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

namespace RemoveSomeElementFromArrayAndSortIt
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            List<int> sortedList = new List<int>();

            // get the middle value of numbers in array
            int middle = 3;

            int start = 0;

            // get the new array first number
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > middle)
                {
                    continue;
                }
                else
                {
                    start = i;
                    sortedList.Add(start);
                    break;
                }
            }

            for (int i = start + 1; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    // if this element is bigger than next or smaller than start element 
                    if (arr[i] > arr[j] && arr[j] > start || arr[i] < start)
                    {                       
                        break;
                    }
                    else
                    {
                        // if this iteration is over, i element is added to list
                        int check = arr[i];
                        if (j == arr.Length - 1)
                        {
                            sortedList.Add(check);
                        }
                    }
                }
            }

            //print result
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.Write(sortedList[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
