using System;

// Write a program to convert binary numbers to their decimal representation.

namespace BinaryToDecimal
{
    public class Program
    {
        static void Main(string[] args)
        {
            int binary = 110110;
            double decilamNum = BinaryToDecimalConversation(binary);

            Console.WriteLine("The decimal representation of {0} is {1}.", binary, decilamNum);
        }

        private static double BinaryToDecimalConversation(int binary)
        {
            string binaryToStr = binary.ToString();

            double decilamNum = 0;
            for (int i = 0; i < binaryToStr.Length; i++)
            {
                decilamNum += Convert.ToDouble(binaryToStr[i].ToString()) * Math.Pow(2, binaryToStr.Length - 1 - i);
            }
            return decilamNum;
        }
    }
}
