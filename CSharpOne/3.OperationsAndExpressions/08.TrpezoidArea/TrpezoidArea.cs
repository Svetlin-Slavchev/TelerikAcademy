using System;
using System.Collections.Generic;
using System.Linq;

// Write an expression that calculates trapezoid's area by given sides a and b and height h.

class TrpezoidArea
{
    static void Main(string[] args)
    {
        Console.Write("sideA: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("sideB: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());
        double TrapezoidArea = ((a + b) / 2) * height;
        Console.WriteLine("Trapezoid Area is: {0}", TrapezoidArea);
    }
}
