using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

class ExcangeBits
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        int mask = 1 << 3;
        int thirdBit = (number & mask) >> 3;

        mask = 1 << 24;
        int twentyFourthBit = (number & mask) >> 24;

        if (thirdBit == 0)
        {
            //put 0 in 24th position
            mask = ~(1 << 24);
            number = number & mask;
        }
        else if (thirdBit == 1)
        {
            //put 1 in 24th position
            mask = 1 << 24;
            number = number | mask;
        }

        if (twentyFourthBit == 0)
        {
            //put 0 in third position
            mask = ~(1 << 3);
            number = number & mask;
        }
        else if (twentyFourthBit == 1)
        {
            //put 1 in third position
            mask = 1 << 3;
            number = number | mask;
        }

        mask = 1 << 4;
        int ForthBit = (number & mask) >> 4;

        mask = 1 << 25;
        int twentyFiveBit = (number & mask) >> 25;

        if (ForthBit == 0)
        {
            //put 0 in 25th position
            mask = ~(1 << 25);
            number = number & mask;
        }
        else if (ForthBit == 1)
        {
            //put 1 in 25th position
            mask = 1 << 25;
            number = number | mask;
        }

        if (twentyFiveBit == 0)
        {
            //put 0 in forth position
            mask = ~(1 << 4);
            number = number & mask;
        }
        else if (twentyFiveBit == 1)
        {
            //put 1 in forth position
            mask = 1 << 4;
            number = number | mask;
        }

        mask = 1 << 5;
        int fiveBit = (number & mask) >> 5;

        mask = 1 << 26;
        int twentySixthBit = (number & mask) >> 26;

        if (fiveBit == 0)
        {
            //put 0 in 26th position
            mask = ~(1 << 26);
            number = number & mask;
        }
        else if (fiveBit == 1)
        {
            //put 1 in 26th position
            mask = 1 << 26;
            number = number | mask;
        }

        if (twentySixthBit == 0)
        {
            //put 0 in five position
            mask = ~(1 << 5);
            number = number & mask;
        }
        else if (twentySixthBit == 1)
        {
            //put 1 in five position
            mask = 1 << 5;
            number = number | mask;
        }

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
