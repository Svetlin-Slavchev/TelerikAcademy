using System;

// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
// Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

namespace GenerateAllVariations
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("without Recursion");
            int N = 3;
            int K = 2;

            int startNumber = 1;

            while (startNumber != N + 1)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine("({0}, {1})", startNumber, i);
                }

                startNumber++;
            }
            Console.WriteLine();

            // with Recursion 
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
                    GenerateCombinations(arr, index + 1, startNum, endNum);
                }
            }
        }
    }
}
