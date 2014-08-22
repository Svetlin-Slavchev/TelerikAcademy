using System;

// Write a program to convert decimal numbers to their binary representation.

namespace DecimalToBinary
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 500;
            string binary = DecimalToBinaryConversation(ref number);

            string reverseBinary = ReverseToRealBinaryNumber(binary);

            Console.WriteLine("The binary representation of number {0} is {1}.", number, reverseBinary);
        }

        public static string ReverseToRealBinaryNumber(string binary)
        {
            // reverse number to real binary
            string reverseBinary = string.Empty;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                reverseBinary += binary[i];
            }
            return reverseBinary;
        }

        public static string DecimalToBinaryConversation(ref int number)
        {
            string binary = "";

            // convert to reversed binary
            while (number != 0)
            {
                binary += number % 2;
                number = number / 2;
            }
            number = 500;
            return binary;
        }
    }
}
