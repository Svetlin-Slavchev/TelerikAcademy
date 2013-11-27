using System;
using System.Numerics;

// Write a program to calculate Nth Catalan number by given N.

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter N: ");
        int numberN = int.Parse(Console.ReadLine());

        int m = 2 * numberN;
        int p = numberN + 1;
        BigInteger firstFactoriel = 1;
        BigInteger secondFactorel = 1;
        BigInteger thirtFactorel = 1;

        do
        {
            firstFactoriel *= m;
            m--;

        } while (m > 0);

        do
        {
            secondFactorel *= p;
            p--;

        } while (p > 0);

        do
        {
            thirtFactorel *= numberN;
            numberN--;

        } while (numberN > 0);

        BigInteger result = firstFactoriel / (secondFactorel * thirtFactorel);

        Console.WriteLine("Nth Catalan number is: " + result);
    }
}


