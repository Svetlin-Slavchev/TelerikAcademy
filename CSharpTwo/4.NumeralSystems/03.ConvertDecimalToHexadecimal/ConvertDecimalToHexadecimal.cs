using System;
using System.Collections.Generic;
using System.Linq;

// Write a program to convert decimal numbers to their hexadecimal representation.

class ConvertDecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a number: ");
        int number = int.Parse(Console.ReadLine());
        DecimalToHexadecimal(number);
    }

    static void DecimalToHexadecimal(int number)
    {
        List<int> myList = new List<int>();
        while (number > 0)
        {
            int remainder = number % 16;
            myList.Add(remainder);
            number = number / 16;
        }

        Console.WriteLine("The number in hecadecimal representation is: ");
        for (int i = myList.Count - 1; i >= 0; i--)
        {
            switch (myList[i])
            {
                case 0: Console.Write("0"); break;
                case 1: Console.Write("1"); break;
                case 2: Console.Write("2"); break;
                case 3: Console.Write("3"); break;
                case 4: Console.Write("4"); break;
                case 5: Console.Write("5"); break;
                case 6: Console.Write("6"); break;
                case 7: Console.Write("7"); break;
                case 8: Console.Write("8"); break;
                case 9: Console.Write("9"); break;
                case 10: Console.Write("A"); break;
                case 11: Console.Write("B"); break;
                case 12: Console.Write("C"); break;
                case 13: Console.Write("D"); break;
                case 14: Console.Write("E"); break;
                case 15: Console.Write("F"); break;
                default:
                    break;
            }
        }
        Console.WriteLine();
    }
}
