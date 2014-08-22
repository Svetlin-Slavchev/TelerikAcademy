using System;
using System.Numerics;

// Write a program that calculates N!*K!/(K-N)! for given N and K (1 < N < K).

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a numbers for N and K (1 < N < K)");
        Console.Write("Enter N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int numberK = int.Parse(Console.ReadLine());
        BigInteger Nfactoriel = 1;
        BigInteger Kfactoriel = 1;
        int thirtFactoriel = (numberK - numberN);
        BigInteger Mfactoriel = 1;

        do
        {
            Nfactoriel *= numberN;
            numberN--;

        } while (numberN > 0);
        Console.WriteLine("N! = " + Nfactoriel);

        do
        {
            Kfactoriel *= numberK;
            numberK--;

        } while (numberK > 0);
        Console.WriteLine("K! = " + Kfactoriel);

        do
        {
            Mfactoriel *= thirtFactoriel;
            thirtFactoriel--;

        } while (thirtFactoriel > 0);
        Console.WriteLine(Mfactoriel);


        BigInteger numerator = Nfactoriel * Kfactoriel;
        BigInteger denominator = Mfactoriel;
        BigInteger result = numerator / denominator;
        Console.WriteLine("The result is: " + result);
    }
}


