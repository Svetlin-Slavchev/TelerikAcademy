using System;

// Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

class CompareFloatingPointNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first number:");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second number:");
        decimal b = decimal.Parse(Console.ReadLine());
        decimal precision = 0.000001M;
        bool compare = (((a < b) & (b - a) < precision) || (a == b) || ((a > b) & (a - b) < precision));
        Console.WriteLine(compare);
    }
}
