using System;

// Write a program, that reads from the console an array of N integers and an integer K,
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

namespace FindLargestNumberWithBinarySearch
{
    public class Program
    {
        static void Main()
        {
            int[] arr = { 2, -4, 10, 8, 1, 0, 3 };
            int numberForSearch = 6; // this is K

            //sorting array
            Array.Sort(arr);

            int findIndex = -1;

            // while Array.BinarySearch return negative number(cant find serching number)
            // we reduce searching number whit 1
            while (findIndex < 0)
            {
                findIndex = Array.BinarySearch(arr,  numberForSearch);
                numberForSearch--;
            }

            Console.WriteLine(arr[findIndex]);
        }
    }
}
