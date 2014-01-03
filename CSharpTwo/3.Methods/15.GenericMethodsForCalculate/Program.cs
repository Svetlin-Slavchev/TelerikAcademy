using System;

// * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
// Use generic method (read in Internet about generic methods in C#).

namespace GenericMethodsForCalculate
{
    public class Program        
    {
        static void Main()
        {
            decimal[] numbers = {3, 5, 6, 1, - 2 };

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

        public static T CalculateProduct<T>(T[] numbers)
        {
            dynamic productOfElement = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                productOfElement *= numbers[i];
            }

           return productOfElement;
        }

        public static T CalculateSum<T>(T[] numbers)
        {
            dynamic sumOfElement = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfElement += numbers[i];
            }

           return sumOfElement;
        }
  
        public static T CalculateAverage<T>(T[] numbers)
        {
            dynamic sumOfElement = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfElement += numbers[i];
            }

           dynamic average = sumOfElement / numbers.Length;
           return average;
        }

        public static T CalculateMaxNumber<T>(T[] numbers)
        {
            dynamic maxNumber = int.MinValue;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                dynamic maxTempNum = Math.Max((dynamic)numbers[i], (dynamic)numbers[i + 1]);

                if (maxTempNum > maxNumber)
                {
                    maxNumber = maxTempNum;
                }
            }

            return maxNumber;
        }

        public static T CalculateMinNumber<T>(T[] numbers)
        {
            dynamic minNumber = int.MaxValue;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                dynamic minTempNum = Math.Min((dynamic)numbers[i], (dynamic)numbers[i + 1]);

                if (minTempNum < minNumber)
                {
                    minNumber = minTempNum;
                }
            }

            return minNumber;
        }
    }
}

