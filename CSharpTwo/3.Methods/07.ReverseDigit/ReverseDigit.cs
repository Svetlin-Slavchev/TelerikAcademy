using System;
using System.Linq;

// Write a method that reverses the digits of given decimal number. Example: 256  652

class ReverseDigit
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string number = n.ToString();      // Set the number as an string
        ReverseDigitOfAnNumber(number);
    }

    static void ReverseDigitOfAnNumber(string number)
    {
        for (int i = number.Length - 1; i >= 0; i--)   // Reverse string
        {
            Console.Write(number[i]);
        }
        Console.WriteLine();
    }
}