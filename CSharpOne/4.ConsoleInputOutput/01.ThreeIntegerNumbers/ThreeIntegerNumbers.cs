using System;

// Write a program that reads 3 integer number from the console and prrints their sum.

class ThreeIntegerNumbers
{
    static void Main()
    {
        Console.Write("Enter a number1: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter a number2: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter a number3: ");
        int number3 = int.Parse(Console.ReadLine());

        int sum = number1 + number2 + number3;
        Console.WriteLine("Sum is: {0}", sum);
    }
}
