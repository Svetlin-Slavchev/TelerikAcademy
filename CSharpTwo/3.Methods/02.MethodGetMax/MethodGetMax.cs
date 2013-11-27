using System;
using System.Linq;

// Write a method GetMax() with two parameters that returns the bigger of two integers. 
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

class MethodGetMax
{
    static void Main(string[] args)
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int numberThree = int.Parse(Console.ReadLine());  
        GetMax(numberThree, GetMax(numberOne, numberTwo));
        int bestNumber = GetMax(numberOne, numberTwo);
        int bestNumber2 = GetMax(numberThree, bestNumber);
        PrintBigestNumber(bestNumber2);   
    }

    static int GetMax(int numberOne, int numberTwo)
    {
        int bestNumber = int.MinValue;
        if (numberOne > numberTwo)
        {
            bestNumber = numberOne;
        }

        if (numberOne < numberTwo)
        {
            bestNumber = numberTwo; 
        }

        if (numberOne == numberTwo)
        {
            bestNumber = numberOne;
            Console.WriteLine("All numbers are equal");
        }
        return bestNumber;
    }

    static void PrintBigestNumber(int number)
    {
        Console.WriteLine("The bigest number is {0}.", number);
    }
}
