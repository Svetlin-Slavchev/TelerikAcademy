using System;

// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
// Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

namespace GenerateAllCombinations
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("without Recursion");
            int N = 5;
            int K = 2;
            int startNumber = 1;

            while (startNumber != N)
            {
                int endNumber = startNumber;
                for (int i = startNumber; i < N; i++)
                {
                    Console.WriteLine("({0}, {1})", startNumber, endNumber + 1);
                    endNumber++;
                }

                startNumber++;
            }

            Console.WriteLine("with Recursion");
            
            int startNum = 1;
            int[] arr = new int[K];
            GenerateCombinations(arr, 0, startNum, N);
        }

        static void GenerateCombinations(int[] arr, int index, int startNum, int endNum)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine("(" + String.Join(", ", arr) + ")");
            }
            else
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(arr, index + 1, i + 1, endNum);
                }
            }      
        }
    }
}
