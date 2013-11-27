using System;

// Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter N as number of integers: ");
        int n = int.Parse(Console.ReadLine());
        int smallnumber = 0;
        int bignumber = 0;

        for (int i = 0; i < n; i++)
        {


            if (i > bignumber)
            {
                bignumber = i;
            }
            if (i <= smallnumber)
            {
                smallnumber = i;
            }

        }
        Console.WriteLine("Smallnumber is: " + smallnumber);
        Console.WriteLine("Bignumber is: " + bignumber);
    }
}


