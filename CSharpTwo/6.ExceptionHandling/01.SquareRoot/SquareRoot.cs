using System;

// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye".
// Use try-catch-finally

class SquareRoot
{
    static void Main()
    {
        try
        {
            CalculateSqrt();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }

    private static void CalculateSqrt()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            throw new ArgumentException();
        }

        Console.WriteLine("The square root is: {0}", Math.Sqrt(number));
    }

}