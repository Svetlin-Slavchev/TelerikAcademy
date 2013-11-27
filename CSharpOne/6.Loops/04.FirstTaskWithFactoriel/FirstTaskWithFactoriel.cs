using System;
using System.Numerics;

// Write a program that calculates N!/K! for given N and K (1 < K < N).

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a numbers for N and K (1 < K < N)");
        Console.Write("Enter N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int numberK = int.Parse(Console.ReadLine());
        BigInteger Nfactoriel = 1;
        BigInteger Kfactoriel = 1;

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

        BigInteger result = Nfactoriel / Kfactoriel;
        Console.WriteLine("Result is: " + result);

    }
}
