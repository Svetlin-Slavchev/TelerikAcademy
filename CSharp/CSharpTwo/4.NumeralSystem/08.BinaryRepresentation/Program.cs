using System;

// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

namespace BinaryRepresentation
{
    public class Program
    {
        static void Main(string[] args)
        {
            short shortNum = 1000;
            int num = shortNum;

            // use methods from task 1
            string binary = DecimalToBinary.Program.DecimalToBinaryConversation(ref num);
            string reverseBinary = DecimalToBinary.Program.ReverseToRealBinaryNumber(binary);

            Console.WriteLine("The binary representation of {0} is {1}.", shortNum, reverseBinary.PadLeft(16, '0'));
        }
    }
}
