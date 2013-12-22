using System;
using System.Collections.Generic;
using System.Text;

// Write a program that finds the most frequent number in an array. Example:
// 	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

namespace MostFrequentNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

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
