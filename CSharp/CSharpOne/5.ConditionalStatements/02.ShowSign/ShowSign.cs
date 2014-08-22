using System;

// Write a program that shows the sign(+ or -) of the product of three real numbers whitout calculating it. 
// Use a sequence of if statements.

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

    if (a > 0)     
    {
       Console.WriteLine("Number a is positive(+)");
    }
    else if (a < 0)
    {
       Console.WriteLine("Number a is negative(-)");
    }
     if (b > 0)
    {
        Console.WriteLine("Number b is positive(+)");
    }
    else if (b < 0)
    {
        Console.WriteLine("Number b is negative(-)");
    }
     if (c > 0)
    {
        Console.WriteLine("Number c is positive(+)");
    }
    else if (c < 0)
    {
        Console.WriteLine("Number c is negative(-)");
    }
    else 
        Console.WriteLine("Number is 0");
    }

       
 }


