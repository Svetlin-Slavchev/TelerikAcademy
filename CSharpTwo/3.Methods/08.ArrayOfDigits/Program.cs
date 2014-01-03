using System;
using System.Numerics;

// Write a method that adds two positive integer numbers represented as arrays of digits
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

namespace ArrayOfDigits
{
    public class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] firstArr = { 3, 5, 6 };
            BigInteger[] secondArr = { 4, 5, 8 };

            Console.WriteLine("The sum of two integer arrays is : {0}", 
                SumOfIntegerArrays(firstArr, secondArr));           
        }

        private static BigInteger SumOfIntegerArrays(BigInteger[] firstArr, BigInteger[] secondArr)
        {
            // reverse the numbers
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);

            // concat digits in string
            string stringFirstNum = string.Join("", firstArr);
            string stringSecondNum = string.Join("", secondArr);

            // parse string to number
            BigInteger firstNumber = int.Parse(stringFirstNum);
            BigInteger secondNumber = int.Parse(stringSecondNum);

            BigInteger result = firstNumber + secondNumber;

            return result;
        }
    }
}
