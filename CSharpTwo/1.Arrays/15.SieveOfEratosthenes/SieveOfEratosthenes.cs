using System;
using System.Linq;

// Write a program that finds all prime numbers in the range [1...10 000 000].
// Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

class SieveOfEratosthenes
{
    static void Main(string[] args)
    {
        long num = 10000000;

        for (long i = 0; i <= num; i++)
        {

            bool isPrime = true;
            for (long j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)   // isPrime = true;
            {
                Console.WriteLine("Prime: " + i);
            }
        }
    }
}
