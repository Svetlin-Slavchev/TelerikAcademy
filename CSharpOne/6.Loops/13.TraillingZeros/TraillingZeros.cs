using System;
using System.Numerics;

// Write a program that calculates for given N how many trailing zeros present at the end of the number N.
// Examples: N = 10 -> N! = 3628800 -> 2
// N = 20 -> N! = 2432902008176640000 -> 4

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number for N: ");
        int number = int.Parse(Console.ReadLine());

        int zeros = number / 5;

        BigInteger factoriel = 1;

        do
        {
            factoriel *= number;
            number--;

        } while (number > 0);

        Console.WriteLine("N! is: " + factoriel);
        Console.WriteLine("The trailing zeros in N! is: " + zeros);
    }
}
