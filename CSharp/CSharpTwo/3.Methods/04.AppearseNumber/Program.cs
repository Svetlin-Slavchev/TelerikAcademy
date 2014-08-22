using System;
using System.Collections.Generic;
using System.Text;

// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is working correctly.

namespace AppearseNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 2, 3, 6, 3, 3 };

            CalculateRepeatingNumbers(arr);
        }

        private static void CalculateRepeatingNumbers(int[] arr)
        {
            int count = 0;
            StringBuilder sb = new StringBuilder();
            List<int> uniqElements = new List<int>();
            // bool variable for checking unique number and white write it on the console
            bool repeatNumbers = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && !uniqElements.Contains(arr[i]))
                    {
                        count++;
                        uniqElements.Add(arr[i]);
                        repeatNumbers = false;
                    }
                    else if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (uniqElements.Contains(arr[i]) && repeatNumbers == false)
                {
                    Console.WriteLine("Element {0} - {1} times!", arr[i], count);
                    count = 0;
                    repeatNumbers = true;
                }
                else
                {
                    count = 0;
                }
            }
        }         
    }
}
