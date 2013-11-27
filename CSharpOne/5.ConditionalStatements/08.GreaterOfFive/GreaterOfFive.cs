using System;

// Write a program that finds the greatest of given 5 variables.

class Program
{
    static void Main()
    {

        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        int fifthNumber = int.Parse(Console.ReadLine());

        double greatestnumber = firstNumber;

        if (greatestnumber < secondNumber)
        {
            greatestnumber = secondNumber;
        }
        if (greatestnumber < thirdNumber)
        {
            greatestnumber = thirdNumber;
        }
        if (greatestnumber < fourthNumber)
        {
            greatestnumber = fourthNumber;
        }
        if (greatestnumber < fifthNumber)
        {
            greatestnumber = fifthNumber;
        }
        Console.WriteLine("The greatest number is: {0}", greatestnumber);
    }
}
