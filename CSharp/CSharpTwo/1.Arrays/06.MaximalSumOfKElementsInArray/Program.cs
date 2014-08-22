using System;

// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

namespace MaximalSumOfKElementsInArray
{
    public class Program
    {
        static void Main()
        {
            //int K = int.Parse(Console.ReadLine());
            //int N = int.Parse(Console.ReadLine());

            //int[] arr = new int[N];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            int K = 3;
            int N = 9;

            int sum = 0;
            int maximalSum = int.MinValue;
            string numbers = "";
            string maxSumOfNumbers = null;

            int[] arr = { 3, 2, 3, 4, 2, 2, 4, 5, 6 };

            for (int i = 0; i < arr.Length - K + 1; i++)
            {
                for (int q = i; q < K + i; q++)
                {
                    sum += arr[q];
                    numbers += string.Format("{0} ", arr[q]);
                }
                // remove last "space"
                numbers = numbers.Remove(numbers.Length - 1);

                if (sum > maximalSum)
                {
                    maximalSum = sum;
                    maxSumOfNumbers = numbers;
                    // reset "numbers" and sum to search new maximal sum
                    numbers = "";
                    sum = 0;
                }
                else
                {
                    // reset "numbers" and sum to search new maximal sum
                    numbers = "";
                    sum = 0;
                }
            }

            Console.WriteLine("Maximal sum is {0} from {1} elements", maximalSum, maxSumOfNumbers);
        }
    }
}
