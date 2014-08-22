using System;

// Write a program that gets two numbers from the console and prints the greater of them. Don't use if statements. 

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter number1: ");
        decimal number1 = decimal.Parse(Console.ReadLine());

        Console.Write("Enter number2: ");
        decimal number2 = decimal.Parse(Console.ReadLine());

        decimal result = Math.Max(number1, number2);
        Console.WriteLine("Greater of the numbers is:{0}",result);
    }
}

