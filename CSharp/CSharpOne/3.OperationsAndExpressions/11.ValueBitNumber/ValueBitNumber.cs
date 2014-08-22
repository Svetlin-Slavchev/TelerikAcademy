using System;
using System.Collections.Generic;
using System.Linq;

// Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

class ValueBitNumber
{
    static void Main(string[] args)
    {
        int i = int.Parse(Console.ReadLine());
        int bitPosition = int.Parse(Console.ReadLine());
        int mask = 1 << bitPosition;
        int iAndMask = i & mask;
        int value = iAndMask >> bitPosition;
        Console.WriteLine(value);
    }
}
