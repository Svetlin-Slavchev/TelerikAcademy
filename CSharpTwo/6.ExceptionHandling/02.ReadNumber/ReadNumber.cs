using System;
using System.Linq;
using System.Threading;

// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

class ReadNumber
{
    static int count = 0;
    
    static void Main(string[] args)
    {
        int start = 20;
        // int start = int.Parse(Console.ReadLine());
        int end = 90;
        // int end = int.Parse(Console.ReadLine());
        try
        {
            ReadIntegerNumber(start, end);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            TenNumbers(start, end);
        }
        
    }

    static void ReadIntegerNumber(int start, int end)
    {
        Thread.Sleep(200); // Make speed slower to generate random numbers
        Random rand = new Random();
        int myNumber = rand.Next(1, 100);
        // int myNumber = int.Parse(Console.ReadLine());
        if ((myNumber < start) || (myNumber > end))
        {
            count++;
            throw new Exception();         
        }
        else
        {
            Console.WriteLine("Number {0}.", myNumber);
            count++;
        }   
    }

    static void TenNumbers(int start, int end)
    {
        
        for (int i = 1; i < (count = 10); i++)
        {
            ReadIntegerNumber(1, 100);
        }
    }
}
