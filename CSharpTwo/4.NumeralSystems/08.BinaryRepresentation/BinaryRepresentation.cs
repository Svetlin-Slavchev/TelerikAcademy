using System;
using System.Linq;

// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class BinaryRepresentation
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        short number = short.Parse(Console.ReadLine());
        Console.Write("Number in binary representation is: ");
        // convert number in '2' base numeral system. PadLeft fills empty spaces whit '0' until they аrе 16
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
    }
}
