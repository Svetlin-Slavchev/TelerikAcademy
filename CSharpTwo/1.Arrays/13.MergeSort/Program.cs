using System;

// * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

namespace MergeSort
{
    public class MergeSort
    {
        public static void Main()
        {
            int[] arr = { 5, 1, 5, -8, 2, 9, -5, 4 };

            for (int i = 1; i < arr.Length; i *= 2)
            {
                int[] result = new int[arr.Length];

                for (int leftStart = 0; leftStart < arr.Length; leftStart += 2 * i)
                {
                    int rightStart = Math.Min(leftStart + i, arr.Length);
                    int rightEnd = Math.Min(leftStart + (2 * i), arr.Length);
                    MergeSortedPartsOfArray(arr, leftStart, rightStart, rightEnd, result);
                }

                arr = result;
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        public static void MergeSortedPartsOfArray(
             int[] arr1,
             int leftStart,
             int rightStart,
             int rightEnd,
             int[] result)
        {
            int resultIndex;
            int leftEnd = rightStart - 1;

            for (resultIndex = leftStart; resultIndex < rightEnd; resultIndex++)
            {
                if (leftStart <= leftEnd &&
                    (rightStart >= rightEnd || arr1[leftStart] <= arr1[rightStart]))
                {
                    result[resultIndex] = arr1[leftStart];
                    leftStart++;
                }
                else
                {
                    result[resultIndex] = arr1[rightStart];
                    rightStart++;
                }
            }
        }
    }
}
