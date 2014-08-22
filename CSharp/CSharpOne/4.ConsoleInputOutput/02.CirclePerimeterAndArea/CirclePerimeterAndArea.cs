using System;

// Write a program that reads the radius r of a circle and prints its perimeter and area.

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter a circle's radius: ");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double perimeter = 2 * radius * pi;
        double circleArea = radius * radius * pi;

        Console.WriteLine("The perimeter of circle is: {0}",perimeter);
        Console.WriteLine("The area of circle is: {0}",circleArea);
    }
}

