using System;

// Write a program that gets a number n and after that gets more numbers n and calculates and prints their sum.

class NumbersSum
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter one more number: ");
        int number2 = int.Parse(Console.ReadLine());
        int sum = number1 + number2;
        Console.Write("Enter one more number: ");
        int number3 = int.Parse(Console.ReadLine());
        sum = number1 + number2 + number3;
        Console.Write("Enter one more number: ");
        int number4 = int.Parse(Console.ReadLine());
        sum = number1 + number2 + number3 + number4;
        Console.WriteLine("The sum is " + sum);
    }
}

