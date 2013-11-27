using System;

// Write a program that generates and prints to the console 10 random values in the range [100, 200].

class TenRandomValues
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            int numbers = rand.Next(100) + 101;    // Return numbers in range [100, 200]
            Console.WriteLine(numbers);
        }
    }
}

