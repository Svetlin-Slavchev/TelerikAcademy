using System;
using System.Collections.Generic;
using System.Linq;

// Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v 
// has value of 1. Example: v=5; p=1  false.

class ReturnsBit
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        byte position = byte.Parse(Console.ReadLine());
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;

        Console.WriteLine(bit);

        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
