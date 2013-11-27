using System;
using System.Collections.Generic;
using System.Linq;

// Write a program to convert hexadecimal numbers to binary numbers (directly).

class ConvertHexadecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter a hexadecimal number: ");
        string hexadecimalNumber = Console.ReadLine();
        HexadecimalToBinary(hexadecimalNumber);
    }

    static void HexadecimalToBinary(string hexadecimalNumber)
    {
        Console.Write("The number in binary representation is: ");
        for (int i = 0; i < hexadecimalNumber.Length ; i++)
        {
            switch (hexadecimalNumber[i])
            {
                case '0': Console.Write("0000"); break;
                case '1': Console.Write("0001"); break;
                case '2': Console.Write("0010"); break;
                case '3': Console.Write("0011"); break;
                case '4': Console.Write("0100"); break;
                case '5': Console.Write("0101"); break;
                case '6': Console.Write("0110"); break;
                case '7': Console.Write("0111"); break;
                case '8': Console.Write("1000"); break;
                case '9': Console.Write("1001"); break;
                case 'A': Console.Write("1010"); break;
                case 'B': Console.Write("1011"); break;
                case 'C': Console.Write("1100"); break;
                case 'D': Console.Write("1101"); break;
                case 'E': Console.Write("1110"); break;
                case 'F': Console.Write("1111"); break;
                default:
                    break;
            }
        }
        Console.WriteLine();
    }
}