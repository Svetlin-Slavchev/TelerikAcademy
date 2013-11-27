using System;

// Write a program that reads the coefficients a, b and c of a quadratic equation a*x*x + b*x + c = 0 and solves it(prints its real roots).

class ProgrQuadraticEquationam
{
    static void Main()
    {
        Console.Write("Enter number for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number for c: ");
        double c = double.Parse(Console.ReadLine());

        double D = (b * b) - (4 * a * c);

        if (D > 0)
        {
            double x1 = ((-b) + (Math.Sqrt(D))) / 2 * a;
            double x2 = ((-b) - (Math.Sqrt(D))) / 2 * a;
            Console.WriteLine("The real roots are:{0} and {1}", x1, x2);
        }

        else if (D == 0)
        {
            double x = (-b)  / 2 * a;
            Console.WriteLine("The real roots are:{0}", x);  
        }

        else if(D < 0)
        {
            Console.WriteLine("False!");
        }
    }
}

