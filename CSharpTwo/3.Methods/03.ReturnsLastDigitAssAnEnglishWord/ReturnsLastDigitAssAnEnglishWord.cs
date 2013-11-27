using System;
using System.Linq;

// Write a method that returns the last digit of given integer as an English word. 
// Examples: 512  "two", 1024  "four", 12309  "nine".

class ReturnsLastDigitAssAnEnglishWord
{
    static void Main(string[] args)
    {
        string digit = Console.ReadLine();
        LastDigit(digit);
    }

    static void LastDigit(string digit)
    {
        int number = int.Parse(digit);
        if (number < 0)
        {
            number *= (-1);     // If number is negative - mate it positive
        }
        int lastDigitOfNumber = number % 10;    // work only with positives number
        switch (lastDigitOfNumber)
        {
            case 0: Console.WriteLine("Zero"); break;
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            default: Console.WriteLine("This is not a number");break;
        }  
    }
}
