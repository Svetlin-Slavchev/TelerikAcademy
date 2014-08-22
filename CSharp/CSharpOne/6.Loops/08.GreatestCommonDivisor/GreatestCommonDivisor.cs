using System;

// Write the program that calculates the greatest common divisior (GCD) of given two integers. Use the Euclidean algorithm

class Program
{
    static void Main()
    {
        Console.Write("Enter a number for A: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for B: ");
        int B = int.Parse(Console.ReadLine());

        int remainder = A % B;
        int GCD;

        for (int i = 0; i < A; i++)
        {
            if (A % B == 0)
            {
                Console.WriteLine("Greatest common divisor is: " + (A / B));
                break;
            }
            remainder = A % B;
            A = B;
            B = remainder;

        }
    }
}

