using System;

// Write a method that reverses the digits of given decimal number. Example: 256  652

namespace ReverseDigits
{
    public class Program
    {
        static void Main()
        {
            int number = 256;

            ReverseNumber(number);
        }

        private static void ReverseNumber(int number)
        {
            // make number to string to use its method Lenght and reverse by iterate whit for cicle
            string stringNum = number.ToString();
            string reversNum = "";

            for (int i = stringNum.Length - 1; i >= 0; i--)
            {
                reversNum += stringNum[i].ToString();
            }

            Console.WriteLine(reversNum);
        }
    }
}
