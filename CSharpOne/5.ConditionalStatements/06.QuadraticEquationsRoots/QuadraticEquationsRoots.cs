using System;

// Write a program that enters the coefficients a, b and c of a quadratic equation a*x*x + b*x + c = 0 and calculates and prints its real roots.
// Note that quadratic equations may have 0,1 or 2 real roots.

class Program
{
    static void Main()
    {
        Console.Write("Enter number for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number for c: ");
        double c = double.Parse(Console.ReadLine());

        double D = (b * b) - (4 * a * c);  // Formula for 'D'

        if (D > 0)
        {
            double x1 = ((-b) + (Math.Sqrt(D))) / 2 * a;   // Formula for x1
            double x2 = ((-b) - (Math.Sqrt(D))) / 2 * a;   // for x2
            Console.WriteLine("The real roots are:{0} and {1}", x1, x2);
        }

        else if (D == 0)
        {
            double x = (-b) / 2 * a;
            Console.WriteLine("The real roots are:{0}", x);
        }

        else if (D < 0)
        {
            Console.WriteLine("There is no real roots!");
        }
    }
}

