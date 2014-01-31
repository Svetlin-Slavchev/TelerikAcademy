using System;

namespace QuickSort
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 2, 1, 6, 2, 5, 3 };

            int left = 0;
            int right = arr.Length - 1;

            QuickSortImplementation(arr, left, right);

            PrintArray(arr);
        }

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

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("{" + string.Join(",", arr) + "}");
        }
    }
}
