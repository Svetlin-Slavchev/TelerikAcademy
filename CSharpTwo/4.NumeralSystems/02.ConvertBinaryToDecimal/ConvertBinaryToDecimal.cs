using System;
using System.Collections.Generic;
using System.Linq;

// Write a program to convert binary numbers to their decimal representation.

class ConvertBinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a number in binary representation: ");
        string binaryNumber = Console.ReadLine();
        string reverseNumber = "";
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            //reverse input number
            reverseNumber += binaryNumber[i];       
        }

        BinaryToDecimal(reverseNumber);
    }

    static void BinaryToDecimal(string reverseNumber)
    { 
        int sum = 0;
   
        for (int i = 0; i < reverseNumber.Length; i++)
        {
            int digit = int.Parse(reverseNumber[i].ToString());
            digit = digit * ((int)(Math.Pow(2, i)));                // first digit = digit * 2^0
            sum += digit;                                            // second =  digit * 2^1 .....
        }

        Console.WriteLine("Number in decimal representation is {0}", sum);
    }   
}