using System;
using SelectionSortAlgorithm;

// Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

namespace QuickSort
{
    public class Program
    {
        public static void QuickSortImplementation(int[] arr, int left, int right)
        {
            int basicLeft = left;
            int basicRight = right;
            int pivot = arr[left];

            while (left < right)
            {
                while ((arr[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    arr[left] = arr[right];
                    left++;
                }

                while ((arr[left] <= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    arr[right] = arr[left];
                    right--;
                }
            }

            arr[left] = pivot;
            pivot = left;
            left = basicLeft;
            right = basicRight;

            if (left < pivot)
            {
                QuickSortImplementation(arr, left, pivot - 1);
            }

            if (right > pivot)
            {
                QuickSortImplementation(arr, pivot + 1, right);
            }
        }

        static void Main()
        {
            int[] arr = { 2, 1, 6, 2, 5, 3 };

            int left = 0;
            int right = arr.Length - 1;

            QuickSortImplementation(arr, left, right);

            // invoke PrintArray method from task 7 in this homework
            SelectionSortAlgorithm.Program.PrintArray(arr);
        }
    }
}
