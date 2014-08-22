using System;
using System.Collections.Generic;
using System.Linq;

// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

class ThirtDigit
{
    static void Main(string[] args)
    {
        Console.Write("Enter an number: ");
        int number = int.Parse(Console.ReadLine());
        int ThirtDigit = ((number / 100) % 10);
        if (ThirtDigit == 7)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
