using System;
using System.Collections.Generic;

// Write a program to convert hexadecimal numbers to their decimal representation.

namespace HexadecimalToDecimal
{
    public class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalNum = "1F4";
            List<string> list = new List<string>();

            ConvertHexadecimalDigitsToDecimalDigits(hexadecimalNum, list);
            double decilamNum = ConvertToDigitsToRealDecimalNumber(list);

            Console.WriteLine("The decimal representation of {0} is {1}.", hexadecimalNum, decilamNum);
        }

        private static double ConvertToDigitsToRealDecimalNumber(List<string> list)
        {
            double decilamNum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                decilamNum += Convert.ToDouble(list[i].ToString()) * Math.Pow(16, list.Count - 1 - i);
            }

            return decilamNum;
        }

        private static void ConvertHexadecimalDigitsToDecimalDigits(string hexadecimalNum, List<string> list)
        {
            for (int i = 0; i < hexadecimalNum.Length; i++)
            {
                string hexaStrTemp = hexadecimalNum[i].ToString();

                switch (hexaStrTemp)
                {
                    case "A": hexaStrTemp = "10"; break;
                    case "B": hexaStrTemp = "11"; break;
                    case "C": hexaStrTemp = "12"; break;
                    case "D": hexaStrTemp = "13"; break;
                    case "E": hexaStrTemp = "14"; break;
                    case "F": hexaStrTemp = "15"; break;
                    default:
                        break;
                }

                list.Add(hexaStrTemp);
            }
        }
    }
}
