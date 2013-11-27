using System;

// Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,...

class Program
{
    static void Main()
    {
        Console.Write("Enter a number for N: ");
        long number = long.Parse(Console.ReadLine());

        long firstnumber = 0;
        long secondnumber = 1;
        long result = 0;
        long sum = 0;
        long overResult = 0;
        for (int i = 2; i < number; i++)
        {
            result = firstnumber + secondnumber;
            firstnumber = secondnumber;
            secondnumber = result;
            sum += result;
            overResult = sum + 1;
        }
        Console.WriteLine(overResult);
    }
}

