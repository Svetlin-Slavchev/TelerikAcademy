using System;

// Write a method GetMax() with two parameters that returns the bigger of two integers.
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

namespace _GetMaxMethod
{
    public class Program
    {
        static void Main()
        {
            int numOne = 5;
            int numTwo = 2;
            int numThree = 15;

            int biggestNumber = GetMax(numOne, GetMax(numTwo, numThree));
            Console.WriteLine("The biggest number is {0}.", biggestNumber);
        }

        public static int GetMax(int numberOne, int numberTwo)
        {
            int maxNumber = Math.Max(numberOne, numberTwo);

            return maxNumber;
        }
    }
}
