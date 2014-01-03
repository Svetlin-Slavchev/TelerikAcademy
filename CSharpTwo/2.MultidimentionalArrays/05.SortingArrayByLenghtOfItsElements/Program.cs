using System;

// You are given an array of strings. Write a method that sorts the array by the length of its elements
// (the number of characters composing them).

namespace SortingArrayByLenghtOfItsElements
{
    public class Program
    {
        static void Main()
        {
            string[] arr = {                            
                              "portokala",
                              "ala",
                              "bala",
                           };

            SortByElementsLenght(arr);
            PrintArray(arr);
        }

        // method for sorting array
        public static string[] SortByElementsLenght(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i; j < arr.Length; j++)
                {
                    // find lowest element
                    if (arr[j].Length < arr[min].Length)
                    {
                        min = j;
                    }
                }
                // move lowest element to i position
                string temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            return arr;
        }

        // method for printing array
        public static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
