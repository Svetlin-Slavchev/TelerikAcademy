using System;
using System.Collections.Generic;
using System.Text;

// Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace HexadecimalToBinary
{
    public class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalNum = "1F4";
            List<string> list = new List<string>();

            ConvertHexadecimalDigitsToBinaryDigits(hexadecimalNum, list);

            int binaryNum = ConvertDigitsToRealBynaryNumber(list);

            Console.WriteLine("The binary representation of {0} is {1}.", hexadecimalNum, binaryNum);
        }

        private static int ConvertDigitsToRealBynaryNumber(List<string> list)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
            }

            int binaryNum = int.Parse(sb.ToString());

            return binaryNum;
        }

        private static void ConvertHexadecimalDigitsToBinaryDigits(string hexadecimalNum, List<string> list)
        {
            for (int i = 0; i < hexadecimalNum.Length; i++)
            {
                string hexaStrTemp = hexadecimalNum[i].ToString();

                switch (hexaStrTemp)
                {
                    case "0": hexaStrTemp = "0000"; break;
                    case "1": hexaStrTemp = "0001"; break;
                    case "2": hexaStrTemp = "0010"; break;
                    case "3": hexaStrTemp = "0011"; break;
                    case "4": hexaStrTemp = "0100"; break;
                    case "5": hexaStrTemp = "0101"; break;
                    case "6": hexaStrTemp = "0110"; break;
                    case "7": hexaStrTemp = "0111"; break;
                    case "8": hexaStrTemp = "1000"; break;
                    case "9": hexaStrTemp = "1001"; break;
                    case "A": hexaStrTemp = "1010"; break;
                    case "B": hexaStrTemp = "1011"; break;
                    case "C": hexaStrTemp = "1100"; break;
                    case "D": hexaStrTemp = "1101"; break;
                    case "E": hexaStrTemp = "1110"; break;
                    case "F": hexaStrTemp = "1111"; break;
                    default:
                        break;
                }

                list.Add(hexaStrTemp);
            }
        }
    }
}
