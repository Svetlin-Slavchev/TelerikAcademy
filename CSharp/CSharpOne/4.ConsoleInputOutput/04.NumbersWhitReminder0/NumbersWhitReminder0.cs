using System;

// Write a program that reads two positive integer numbers and print how many numbers p exist between them such that 
//  the reminder of the division by 5 is 0(inclusive). Example: p (17,25) = 2.

class NumbersWhitReminder0
{
    static void Main()
    {
        Console.Write("Number n is: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Number m is: ");
        uint m = uint.Parse(Console.ReadLine());

        for (uint i = n; i <= m; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("Numbers between n and m that the reminder of the division by 5 is 0 are: {0} number", i);
            }

        }
    }
}

