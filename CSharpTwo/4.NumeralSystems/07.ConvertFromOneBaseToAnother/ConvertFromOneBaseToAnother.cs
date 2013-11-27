using System;
using System.Collections.Generic;
using System.Linq;

// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

class ConvertFromOneBaseToAnother
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter a number in numeral system you want: ");
        string number = Console.ReadLine();
        // string number = "1111";
        Console.Write("Please, enter a numeral system from which we start: ");
        int s = int.Parse(Console.ReadLine());
        // int s = 2;
        Console.Write("Please, enter a numeral system to which we will finish: ");
        int d = int.Parse(Console.ReadLine());
        //int d = 16;

        ConvertFromDecimal(ConvertToDecimal(number, s), d);
    }

    static string ConvertToDecimal(string number, int s)
    {
        int decimalNumber = 0;
        string reverseNumber = "";
        for (int i = number.Length - 1; i >= 0; i--)
        {
            //reverse input number
            reverseNumber += number[i];
        }

        if (s > 9)  // if 's' base is bigger than decimal base
        {
            for (int i = 0; i < reverseNumber.Length; i++)
            {
                int n = 0;
                switch (reverseNumber[i])
                {
                    case '0': n = 0; break;
                    case '1': n = 1; break;
                    case '2': n = 2; break;
                    case '3': n = 3; break;
                    case '4': n = 4; break;
                    case '5': n = 5; break;
                    case '6': n = 6; break;
                    case '7': n = 7; break;
                    case '8': n = 8; break;
                    case '9': n = 9; break;
                    case 'A': n = 10; break;
                    case 'B': n = 11; break;
                    case 'C': n = 12; break;
                    case 'D': n = 13; break;
                    case 'E': n = 14; break;
                    case 'F': n = 15; break;
                    default:
                        break;
                }
                int digit = n;
                digit = digit * ((int)(Math.Pow(s, i)));
                decimalNumber += digit;
                string newNumber = decimalNumber.ToString();
                number = newNumber;
            }
        }
        else  // if 's' base is not bigger than decimal base
        {
            for (int i = 0; i < reverseNumber.Length; i++)
            {
                int digit = int.Parse(reverseNumber[i].ToString());
                digit = digit * ((int)(Math.Pow(s, i)));
                decimalNumber += digit;
                string newNumber = decimalNumber.ToString();
                number = newNumber;
            }
        }
        return number;
    }

    static void ConvertFromDecimal(string number, int d)
    {
        int decimalNumber = Convert.ToInt32(number);
        List<int> myList = new List<int>();
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % d;
            myList.Add(remainder);
            decimalNumber = decimalNumber / d;
        }

        Console.Write("The number in {0} base representation is: ", d);
        for (int i = myList.Count - 1; i >= 0; i--)
        {
            switch (myList[i])
            {
                case 0: Console.Write("0"); break;
                case 1: Console.Write("1"); break;
                case 2: Console.Write("2"); break;
                case 3: Console.Write("3"); break;
                case 4: Console.Write("4"); break;
                case 5: Console.Write("5"); break;
                case 6: Console.Write("6"); break;
                case 7: Console.Write("7"); break;
                case 8: Console.Write("8"); break;
                case 9: Console.Write("9"); break;
                case 10: Console.Write("A"); break;
                case 11: Console.Write("B"); break;
                case 12: Console.Write("C"); break;
                case 13: Console.Write("D"); break;
                case 14: Console.Write("E"); break;
                case 15: Console.Write("F"); break;
                default:
                    break;
            }
        }
        Console.WriteLine();
    }
}
