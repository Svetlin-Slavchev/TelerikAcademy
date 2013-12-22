using System;

// Write a program that finds all prime numbers in the range [1...10 000 000].
// Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

namespace SieveOfEratosthenes
{
    public class Program
    {
        static void Main()
        {
            DateTime start = DateTime.Now;

            long sum = 0;
            long number = 10000000;

            //by default they're all false
            bool[] arr = new bool[number];

            for (int i = 2; i < number; i++)
            {
                //set all numbers to true
                arr[i] = true;
            }
            // find the prime numbers
            for (int j = 2; j < number; j++)
            {
                if (arr[j])
                {
                    for (long p = 2; (p * j) < number; p++)
                    {
                        arr[p * j] = false;
                    }
                }
            }

            for (int k = 0; k < number; k++)
            {
                if (arr[k])
                {
                    Console.WriteLine(k);
                }
            }

            // checking time that program needs to calculated all numbers :)
            DateTime end = DateTime.Now;
            Console.WriteLine(start);
            Console.WriteLine(end);
            Console.WriteLine(end - start);
        }
    }
}
