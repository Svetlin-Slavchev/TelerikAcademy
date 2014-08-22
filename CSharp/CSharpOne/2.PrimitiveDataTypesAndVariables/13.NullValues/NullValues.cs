using System;

// Create a program that assigns null values to an integer and to double variables. 
// Try to print them on the console, try to add some values or the null literal to them and see the result.

class NullValues
{
    static void Main(string[] args)
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("Are you see variables {0} {1}!?", a, b);
    }
}
