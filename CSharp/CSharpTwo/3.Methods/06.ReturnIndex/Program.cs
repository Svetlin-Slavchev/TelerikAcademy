using System;
using BiggerThanTwoNeighbors;

// Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1,
// if there’s no such element. Use the method from the previous exercise.

namespace ReturnIndex
{
    public class Program
    {
        static void Main()
        {
            int[] arr = { 3, 5, 2, 3, 6, 3, 3 };

            for (int i = 1; i < arr.Length - 1; i++)
            {
                // Using the method from the previous exercise.
                BiggerThanTwoNeighbors.Program.CheckElementIsBiggerThanItsTwoNeighbors(arr, i);
            }
        }
    }
}
