using System;
using System.Collections.Generic;
using System.Linq;

// Write a program to convert binary numbers to hexadecimal numbers (directly).

class ConvertBinaryToHexadecimal
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter a binary number: ");
        // PadLeft fills empty spaces whit '0' until they аrе 32. Can be also 8 or 16 but this is a bigger number.
        string number = Console.ReadLine().PadLeft(32, '0'); 
        BinaryToHexadecimal(number);                         
    }

    static void BinaryToHexadecimal(string number)
    {
        List<string> myList = new List<string>();
        for (int i = 0; i < number.Length; i += 4)
        {
            // Keeps 4 digit in myList
            string binary = "";
            for (int j = i; j < i + 4; j++)
            {
                binary += number[j];

                // check what number in hexadecimal we have
                switch (binary)
                {
                    case "0000": myList.Add("0"); break;
                    case "0001": myList.Add("1"); break;
                    case "0010": myList.Add("2"); break;
                    case "0011": myList.Add("3"); break;
                    case "0100": myList.Add("4"); break;
                    case "0101": myList.Add("5"); break;
                    case "0110": myList.Add("6"); break;
                    case "0111": myList.Add("7"); break;
                    case "1000": myList.Add("8"); break;
                    case "1001": myList.Add("9"); break;
                    case "1010": myList.Add("A"); break;
                    case "1011": myList.Add("B"); break;
                    case "1100": myList.Add("C"); break;
                    case "1101": myList.Add("D"); break;
                    case "1110": myList.Add("E"); break;
                    case "1111": myList.Add("F"); break;
                    default:
                        break;
                }
            }  
        }
        string digit = "";
        for (int i = 0; i < myList.Count; i++)
        {     
            digit += myList[i];    
        }
       // Remove leading zeroes whit TrimStart method
        string hexadecimalNumber = digit.TrimStart('0');
        Console.WriteLine(hexadecimalNumber);
    }
}
