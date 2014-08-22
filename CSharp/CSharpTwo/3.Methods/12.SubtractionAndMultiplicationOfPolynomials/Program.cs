using System;
using AddsTwoPolynomials;

// Extend the program to support also subtraction and multiplication of polynomials.

namespace SubtractionAndMultiplicationOfPolynomials
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal[] firstArr = { 3, 5, 6 };
            decimal[] secondArr = { 4, 5, 8 };
            decimal[] thirdArr = new decimal[firstArr.Length];

            Console.WriteLine("Substraction of polynomials:");
            SubtractionOfPolynomials(firstArr, secondArr);           

            Console.WriteLine("\nMultiplication of polynomials:");
            MultiplicationOfPolynomials(firstArr, secondArr);
        }

        private static void SubtractionOfPolynomials(decimal[] firstArr, decimal[] secondArr)
        {
            decimal[] thirdArr = new decimal[firstArr.Length];

            for (int i = 0; i < firstArr.Length; i++)
            {
                thirdArr[i] = firstArr[i] - secondArr[i];
            }

            // invoke PrintPolynomials method from previous tasks
            AddsTwoPolynomials.Program.PrintPolynomials(thirdArr);
        }

        private static void MultiplicationOfPolynomials(decimal[] firstArr, decimal[] secondArr)
        {
            decimal[] thirdArr = new decimal[firstArr.Length];

            for (int i = 0; i < firstArr.Length; i++)
            {
                thirdArr[i] = firstArr[i] * secondArr[i];
            }

            AddsTwoPolynomials.Program.PrintPolynomials(thirdArr);
        }     
    }
}
