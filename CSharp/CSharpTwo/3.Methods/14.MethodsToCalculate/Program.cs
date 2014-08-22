using System;

// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

namespace MethodsToCalculate
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = { 3, 5, -2, 2, 8, -4, 5 };

            Console.WriteLine("The max number in this sequence is : {0}",
                CalculateMaxNumber(numbers));

            Console.WriteLine("The min number in this sequence is : {0}",
                CalculateMinNumber(numbers));

            Console.WriteLine("The average of all numbers in this sequence is : {0}",
                 CalculateAverage(numbers));

            Console.WriteLine("The sum of all numbers in this sequence is : {0}",
                CalculateSum(numbers));

            Console.WriteLine("The product of all numbers in this sequence is : {0}",
                CalculateProduct(numbers));
        }

        private static int CalculateProduct(int[] numbers)
        {
            int productOfElement = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                productOfElement *= numbers[i];
            }

           return productOfElement;
        }

        private static int CalculateSum(int[] numbers)
        {
            int sumOfElement = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfElement += numbers[i];
            }

           return sumOfElement;
        }
  
        private static int CalculateAverage(int[] numbers)
        {
            int sumOfElement = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfElement += numbers[i];
            }

           int average = sumOfElement / numbers.Length;
           return average;
        }

        private static int CalculateMaxNumber(int[] numbers)
        {
            int maxNumber = int.MinValue;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int maxTempNum = Math.Max(numbers[i], numbers[i + 1]);

                if (maxTempNum > maxNumber)
                {
                    maxNumber = maxTempNum;
                }
            }

            return maxNumber;
        }

        private static int CalculateMinNumber(int[] numbers)
        {
            int minNumber = int.MaxValue;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minTempNum = Math.Min(numbers[i], numbers[i + 1]);

                if (minTempNum < minNumber)
                {
                    minNumber = minTempNum;
                }
            }

            return minNumber;
        }
    }
}
