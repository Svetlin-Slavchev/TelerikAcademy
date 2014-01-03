using System;

// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461

namespace StringOfIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "43 68 9 23 318";

            Console.WriteLine("The sum is {0}.", SumOfIntegersInString(str));
        }

        private static int SumOfIntegersInString(string str)
        {
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    sum += int.Parse(str[i].ToString());
                }
            }

            return sum;
        }
    }
}
