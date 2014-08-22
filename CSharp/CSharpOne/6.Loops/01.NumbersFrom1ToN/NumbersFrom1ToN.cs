using System;

// Write a program that prints all the numbers from 1 to n.

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }
    }
}
