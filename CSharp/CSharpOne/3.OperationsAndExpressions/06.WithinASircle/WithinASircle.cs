using System;
using System.Collections.Generic;
using System.Linq;

// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

class WithinASircle
{
    static void Main(string[] args)
    {
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());
        double centerX = 0;
        double centerY = 0;

        double resultX = (pointX - centerX)
            * (pointX - centerX);
        double resultY = (pointY - centerY)
             * (pointY - centerY);

        double endResult = resultX + resultY;

        double radius = 5;

        bool isWithinCircle = endResult <
            radius * radius;

        Console.WriteLine(isWithinCircle);
    }
}
