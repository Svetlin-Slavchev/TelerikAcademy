using System;

// Write a pogramm that for a given two integer N and X, calculates the sum S = 1 + 1!/X + 2!/X*X + ... + N!/X^N 

class Program
{
    static void Main()
    {
        Console.Write("Enter a number for N: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for x: ");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1m;
        decimal factoriel = 1m;
        int xPower = x;

        for (int k = 1; k < number; k++)
        {
            factoriel *= k;
            xPower = (int)Math.Pow(x, k);
            sum += (factoriel / xPower);
        }


        Console.WriteLine(sum);
    }
}
