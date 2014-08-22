using System;

// Write a program that reads a number and prints it as a decimal number, 
// hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.

namespace SomeStringFormating
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 50;

            Console.WriteLine(number.ToString("D").PadLeft(15, ' '));
            Console.WriteLine(number.ToString("X").PadLeft(15, ' '));
            Console.WriteLine(number.ToString("P").PadLeft(15, ' '));
            Console.WriteLine(number.ToString("E").PadLeft(15, ' '));
        }
    }
}
