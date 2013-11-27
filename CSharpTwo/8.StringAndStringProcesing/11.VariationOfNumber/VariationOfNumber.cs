using System;
using System.Linq;

// Write a program that reads a number and prints it as a decimal number, hexadecimal number,
// percentage and in scientific notation. Format the output aligned right in 15 symbols.

class VariationOfNumber
{
    static void Main(string[] args)
    {
        double number = 1578.5;
        int num = (int)number;
        Console.WriteLine(Convert.ToString(number).PadLeft(15, ' '));
        Console.WriteLine(num.ToString("X").PadLeft(15, ' '));
        Console.WriteLine(number.ToString("p1").PadLeft(15, ' '));
        Console.WriteLine(number.ToString("G2").PadLeft(15, ' '));
    }
}
