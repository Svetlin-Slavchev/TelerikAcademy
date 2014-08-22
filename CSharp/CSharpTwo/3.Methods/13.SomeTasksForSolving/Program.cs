using System;

// Write a program that can solve these tasks:
// Reverses the digits of a number
// Calculates the average of a sequence of integers
// Solves a linear equation a * x + b = 0
//		Provide a simple text-based menu for the user to choose which task to solve.
//		Validate the input data:
// The decimal number should be non-negative
// The sequence should not be empty
// a should not be equal to 0

namespace SomeTasksForSolving
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There is some tasks:");
            Console.WriteLine("=========================================");
            Console.WriteLine("1. Reverses the digits of a number");
            Console.WriteLine("2. Calculates the average of a sequence of integers");
            Console.WriteLine("3. Solves a linear equation a * x + b = 0");
            Console.WriteLine("=========================================");
            Console.Write("Write the number of the task you want to solve: ");

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: ReverseNumber(); break;
                case 2: CalculateAverage(); break;
                case 3: LinearEquation(); break;
                default: Console.WriteLine("Invalid number!");
                    break;
            }
        }

        private static void ReverseNumber()
        {
            int number = 256;
            // make number to string to use its method Lenght and reverse by iterate whit for cicle
            string stringNum = number.ToString();
            string reversNum = "";

            for (int i = stringNum.Length - 1; i >= 0; i--)
            {
                reversNum += stringNum[i].ToString();
            }

            Console.WriteLine("The reverse number is {0}.", reversNum);
        }

        private static void CalculateAverage()
        {
            int[] numbers = { 3, 5, -6, 3, 5, 8 };
            int sumOfElement = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfElement += numbers[i];
            }

           int average = sumOfElement / numbers.Length;

           Console.WriteLine("The average is: {0}.", average);
        }
        
        private static void LinearEquation()
        {
            decimal a = 5;
            decimal b = 20;

            decimal x = -b / a;

            Console.WriteLine("X = {0}.", x);
        }
    }
}
