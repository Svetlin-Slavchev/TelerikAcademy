using System;
using System.Collections.Generic;
using System.Linq;

// Write a program to convert decimal numbers to their binary representation.

class ConvertDecimalToBInary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a number: ");
        int number = int.Parse(Console.ReadLine());
        DecimalToBinary(number);
    }

    static void DecimalToBinary(int number)
    {
        List<int> myList = new List<int>();
        while (number > 0)
        {
            int remainder = number % 2;
            myList.Add(remainder);
            number = number / 2;
        }

        Console.WriteLine("The number in binary representation is: ");
        for (int i = myList.Count - 1 ; i >= 0; i--)
        {
            Console.Write(myList[i]);
        }
        Console.WriteLine();
    }
}