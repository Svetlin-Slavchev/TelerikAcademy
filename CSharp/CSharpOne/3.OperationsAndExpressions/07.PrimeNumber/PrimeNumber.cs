using System;
using System.Collections.Generic;
using System.Linq;

// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime

class PrimeNumber
{
    static void Main(string[] args)
    {
        uint number = uint.Parse(Console.ReadLine());
        uint resultToChck = 10;  // this is sqrt100 (n<=100)

        bool Primenumber = (number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0) && (number % 7 > 0)
            || (number == 2) || (number == 3) || (number == 5) || (number == 7);

        Console.WriteLine(Primenumber);
    }
}
