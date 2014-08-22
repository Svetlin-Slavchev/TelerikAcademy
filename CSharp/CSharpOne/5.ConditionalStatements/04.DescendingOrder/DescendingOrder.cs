using System;

// Sort three real values in descending order using nested if statements.

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if ((a <= b) && (a <= c))
        {
            if (b < c)
            {
                Console.WriteLine("The numbers in descending order is {0},{1},{2}",c,b,a);
            }
            else if (b == c)
            {
                Console.WriteLine("The numbers in descending order is {0},{1},{2}", c, b, a);
            }
            else if (b > c)
            {
                Console.WriteLine("The numbers in descending order is {0},{1},{2}", b, c, a);
            }
        }

        if ((b < a) && (b <= c))
        {
            if (a < c)
            {
                Console.WriteLine("The numbers in descending order is {0},{1},{2}", c, a, b);
            }
            else if (a == c)
            {
                Console.WriteLine("The numbers in descending order is {0},{1},{2}", c, a, b);
            }
            else if (a > c)
            {
                Console.WriteLine("The numbers in descending order is {0},{1},{2}", a, c, b);
            }
        }

        if ((c <= a) && (c <= b))
        {
            if (a < b)
            {
                Console.WriteLine("The numbers in descending order is {0},{1},{2}", b, a, c);
            }
            else if (a == b)
            {
                Console.WriteLine("The numbers in descending order is {0},{1},{2}", b, a, c);
            }
            else if (a > b)
            {
                Console.WriteLine("The numbers in descending order is {0},{1},{2}", a, b, c);
            }
        }

        if ((a == b) && (a == c) && (b == c))
        {
            Console.WriteLine("These numbers are equals");
        }
    }
}

