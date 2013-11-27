using System;
using System.Numerics;
using System.Linq;

// Write a program to calculate n! for each n in the range [1..100]. 

class CalculateFactoriel
{
    static void Main(string[] args)
    {
        int number = 100;
        int count = 0;
        count++;
        Factoriel(number, count);
    }

    static BigInteger Factoriel(int number,int count)
    {  
        BigInteger factoriel = 1;  
        while (number > 0)   // calculated factoriel
        {
            factoriel *= number;
            number--;
        }
        count++;                        // Use count to reduce factoriel and after that call the recursion again
        Console.WriteLine(factoriel);
        if (count == 100)               // bottom of the recursion
        {
            return 1;
        }  
        return Factoriel(number + 100 - count, count); ;
    }
}
