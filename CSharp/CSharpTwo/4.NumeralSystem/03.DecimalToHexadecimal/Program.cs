using System;

// Write a program to convert decimal numbers to their hexadecimal representation.

namespace DecimalToHexadecimal
{
    public class Program
    {
        static void Main(string[] args)
        {
            int decimalNum = 500;

            string hexadecimalNumTemp = DecimalToHexadecimalConversation(ref decimalNum);

            string realHexadecimal = ReversToRealHexadecimalNumber(hexadecimalNumTemp);

            Console.WriteLine("Hexadecimal representation of {0} is {1}.", decimalNum, realHexadecimal);
        }

        public static string ReversToRealHexadecimalNumber(string hexadecimalNumTemp)
        {
            string realHexadecimal = string.Empty;
            for (int i = hexadecimalNumTemp.Length - 1; i >= 0; i--)
            {
                realHexadecimal += hexadecimalNumTemp[i];
            }
            return realHexadecimal;
        }

        public static string DecimalToHexadecimalConversation(ref int decimalNum)
        {
            int hexadecimalInt = 0;
            string hexadecimalNumTemp = "";

            while (decimalNum != 0)
            {
                hexadecimalInt = decimalNum % 16;
                string hexaStrTemp = hexadecimalInt.ToString();
                decimalNum = decimalNum / 16;

                switch (hexaStrTemp)
                {
                    case "10": hexaStrTemp = "A"; break;
                    case "11": hexaStrTemp = "B"; break;
                    case "12": hexaStrTemp = "C"; break;
                    case "13": hexaStrTemp = "D"; break;
                    case "14": hexaStrTemp = "E"; break;
                    case "15": hexaStrTemp = "F"; break;
                    default:
                        break;
                }

                hexadecimalNumTemp += hexaStrTemp;
            }
            decimalNum = 500;

            return hexadecimalNumTemp;
        }
    }
}
