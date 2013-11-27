using System;
using System.Collections.Generic;
using System.Linq;

// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

class Bit3
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int bitposition = 3;
        int mask = 1 << bitposition;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> bitposition;
        Console.WriteLine(bit);
    }
}
