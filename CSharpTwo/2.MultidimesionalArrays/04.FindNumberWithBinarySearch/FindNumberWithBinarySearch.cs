using System;

//Write a program, that reads from the console an array of N integers and an integer K, 
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

class FindNumberWithBinarySearch
{
    static void Main(string[] args)
    {
        int[] arr = { 2, 4, 0, 5, -2, 8, 9, 7 };
        int K = 8;

        Array.Sort(arr);
        BinarySearch(arr, K);
    }
    static void BinarySearch(int[] arr, int K)
    {
        int min = 0;
        int lenght = arr.Length;
        int max = lenght - 1;

        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (K > arr[mid])
            {
                if ((K > arr[mid]) && (K < arr[mid + 1]))
                {
                    Console.WriteLine("The bigest number in this array, which is <= K is {0}.", arr[mid]);
                }
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
            if (K == arr[mid])
            {
                Console.WriteLine("The bigest number in this array, which is <= K is {0}.", arr[mid]);
            }
        }
    }
}   

