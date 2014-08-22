using System;
using System.Numerics;

// Write a program to calculate n! for each n in the range [1..100].
// Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

namespace CalculateFactoriel
{
    public class Program
    {
        static void Main()
        {
            BigInteger num = 1;

            while (num != 101)
            {
                Console.WriteLine(Factorial(num));
                num++;
            }
        }

        // calculating factoriel recursively
        public static BigInteger Factorial(BigInteger i)
        {
            if (i <= 1)
            {
                return 1;
            }
                
            return i * Factorial(i - 1);
        }
    }
}
