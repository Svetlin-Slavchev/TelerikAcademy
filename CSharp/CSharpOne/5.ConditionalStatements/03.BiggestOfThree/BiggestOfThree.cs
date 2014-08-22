using System;

// Write a program that finds the biggest of three integers using nested if statements.

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());

        if ((a == b) || (a == c) || (b == c) || (a != b) || (a != c) || (b != c))
        {
            if ((a > b) && (a > c))
            {
                Console.WriteLine("Number a is greater!");
            }
            if ((b > a) && (b > c))
            {
                Console.WriteLine("Number b is greater!");
            }
            if ((c > a) && (c > b))
            {
                Console.WriteLine("Number c is greater!");
            }
        }
 
    }
}

