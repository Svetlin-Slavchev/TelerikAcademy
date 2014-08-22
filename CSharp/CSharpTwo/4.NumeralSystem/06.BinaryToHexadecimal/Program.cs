using System;
using System.Text;

// Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace BinaryToHexadecimal
{
    public class Program
    {
        static void Main(string[] args)
        {
            string binaryStr = "0111111010";
            // binaryStr.Lenght must be 4, 8, 12, 16 and so on....
            if (binaryStr.Length % 4 != 0)
            {
                int needZerous = binaryStr.Length % 4;
                binaryStr = binaryStr.PadLeft(binaryStr.Length + needZerous, '0');
            }

            StringBuilder sb = new StringBuilder();
            ConvertBinaryToHexadecimal(binaryStr, sb);

            Console.WriteLine("The hexadecimal representation of {0} is {1}.", binaryStr, sb.ToString());
        }

        private static void ConvertBinaryToHexadecimal(string binaryStr, StringBuilder sb)
        {
            for (int i = 0; i < binaryStr.Length; i += 4)
            {
                string strTemp = "";
                for (int j = i; j < i + 4; j++)
                {
                    strTemp += binaryStr[j];
                }

                switch (strTemp)
                {
                    case "0000": strTemp = "0"; break;
                    case "0001": strTemp = "1"; break;
                    case "0010": strTemp = "2"; break;
                    case "0011": strTemp = "3"; break;
                    case "0100": strTemp = "4"; break;
                    case "0101": strTemp = "5"; break;
                    case "0110": strTemp = "6"; break;
                    case "0111": strTemp = "7"; break;
                    case "1000": strTemp = "8"; break;
                    case "1001": strTemp = "9"; break;
                    case "1010": strTemp = "A"; break;
                    case "1011": strTemp = "B"; break;
                    case "1100": strTemp = "C"; break;
                    case "1101": strTemp = "D"; break;
                    case "1110": strTemp = "E"; break;
                    case "1111": strTemp = "F"; break;
                    default:
                        break;
                }

                sb.Append(strTemp);
            }
        }
    }
}
