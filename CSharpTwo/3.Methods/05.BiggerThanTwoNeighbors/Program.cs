using System;

// Write a method that checks if the element at given position in given array of integers
// is bigger than its two neighbors (when such exist).

namespace BiggerThanTwoNeighbors
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 2, 3, 6, 3, 3 };

            // int positiion = int.Parse(Console.ReadLine());
            int position = 4;

            CheckElementIsBiggerThanItsTwoNeighbors(arr, position);
        }

        public static void CheckElementIsBiggerThanItsTwoNeighbors(int[] arr, int position)
        {
            if ((position != 0) && (position < arr.Length - 1))
            {
                if ((arr[position] > arr[position - 1]) && (arr[position] > arr[position + 1]))
                {
                    Console.WriteLine("The element on position {0} is bigger than its neighbors!", position);
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
