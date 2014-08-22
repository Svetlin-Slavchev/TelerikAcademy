using System;

// Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5

namespace AddsTwoPolynomials
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal[] firstArr = { 3, 5, 6 };
            decimal[] secondArr = { 4, 5, 8 };
            decimal[] thirdArr = new decimal[firstArr.Length];

            Console.WriteLine("Add polynomials: ");
            AddPolynomials(firstArr, secondArr);
        }

        public static void PrintPolynomials(decimal[] thirdArr)
        {
            for (int i = thirdArr.Length - 1; i >= 0; i--)
            {
                if (i == thirdArr.Length - 1)
                {
                    Console.Write("{0}*x^{1} ", thirdArr[i], i);
                }
                else
                {
                    if (thirdArr[i] >= 0)
                    {
                        Console.Write("+ {0}*x^{1} ", thirdArr[i], i);
                    }
                    else
                    {
                        Console.Write("{0}*x^{1} ", thirdArr[i], i);
                    }
                }
            }
            Console.WriteLine();
        }

        public static void AddPolynomials(decimal[] firstArr, decimal[] secondArr)
        {
            decimal[] thirdArr = new decimal[firstArr.Length];

            for (int i = 0; i < firstArr.Length; i++)
            {
                thirdArr[i] = firstArr[i] + secondArr[i];
            }

            PrintPolynomials(thirdArr);
        }
    }
}
