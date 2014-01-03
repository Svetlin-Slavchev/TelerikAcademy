using System;

// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

namespace MaxElementAndSortMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 2, 3, 6, 4, 3 };

            try
            {
                // int index = int.Parse(Console.ReadLine());
                int index = 3;
                Console.WriteLine("The max number in this portion of array is {0}", MaxNumber(index, arr));

                int[] newArr = new int[arr.Length - index];
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = arr[i + index];
                }

                SelectionSortAscending(index, newArr);
                Console.Write("This portion of array in ascending order is: ");
                PrintArray(newArr);

                SelectionSortDescending(index, newArr);
                Console.Write("\nThis portion of array in descending order is: ");
                PrintArray(newArr);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Index is not a valid number.");
            }
            catch (Exception)
            {
                Console.WriteLine("There is some error!");
            }
        }

        public static int MaxNumber(int index, int[] arr)
        {
            if (index < 0 || index >= arr.Length)
            {
                throw new ArgumentException();
            }

            int maxNumber = int.MinValue;
            for (int i = index; i < arr.Length - 1; i++)
            {
                int maxTempNum = Math.Max(arr[i], arr[i + 1]);

                if (maxTempNum > maxNumber)
                {
                    maxNumber = maxTempNum;
                }
            }

            return maxNumber;
        }

        public static int[] SelectionSortAscending(int index, int[] newArr)
        {
            for (int i = 0; i < newArr.Length; i++)
            {
                int min = i;
                for (int j = i; j < newArr.Length; j++)
                {
                    // find lowest element
                    if (newArr[j] < newArr[min])
                    {
                        min = j;
                    }
                }
                // move lowest element to i position
                int temp = newArr[i];
                newArr[i] = newArr[min];
                newArr[min] = temp;
            }

            return newArr;
        }

        public static int[] SelectionSortDescending(int index, int[] newArr)
        {
            for (int i = 0; i < newArr.Length; i++)
            {
                int min = i;
                for (int j = i; j < newArr.Length; j++)
                {
                    // find lowest element
                    if (newArr[j] > newArr[min])
                    {
                        min = j;
                    }
                }
                // move lowest element to i position
                int temp = newArr[i];
                newArr[i] = newArr[min];
                newArr[min] = temp;
            }

            return newArr;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
