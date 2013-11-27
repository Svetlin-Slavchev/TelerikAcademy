using System;
using System.Collections.Generic;
using System.Linq;

// Write a program to convert hexadecimal numbers to their decimal representation.

class ConvertHecadecimalToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a number in hexadecimal representation: ");
        string binaryNumber = Console.ReadLine();
        string reverseNumber = "";
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            //reverse input number
            reverseNumber += binaryNumber[i];
        }

        HexadecimalToDecimal(reverseNumber);
    }

    static void HexadecimalToDecimal(string reverseNumber)
    {
        int sum = 0;

        for (int i = 0; i < reverseNumber.Length; i++)
        {
            int n = 0;
            switch (reverseNumber[i])
            {
                case '0': n = 0; break;
                case '1': n = 1; break;
                case '2': n = 2; break;
                case '3': n = 3; break;
                case '4': n = 4; break;
                case '5': n = 5; break;
                case '6': n = 6; break;
                case '7': n = 7; break;
                case '8': n = 8; break;
                case '9': n = 9; break;
                case 'A': n = 10; break;
                case 'B': n = 11; break;
                case 'C': n = 12; break;
                case 'D': n = 13; break;
                case 'E': n = 14; break;
                case 'F': n = 15; break;
                default:
                    break;
            }
            int digit = n;
            digit = digit * ((int)(Math.Pow(16, i)));                // first digit = digit * 16^0
            sum += digit;                                            // second =  digit * 16^1 .....
        }

        Console.WriteLine("Number in decimal representation is {0}", sum);
    }   
}
