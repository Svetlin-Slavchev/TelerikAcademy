using System;

// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

namespace FromAnyNumeralSystemToAnother
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstNumeralSystem = 3; // s
            int secondNumeralSystem = 15; // d

            int numberFromFNS = 210; // from firstNumeralSystem - FNS

            // step 1 - convert to decimal numeral system
            string decimalStr = FromGivenBaseToStringDecimalConversation(numberFromFNS, firstNumeralSystem);
            int decimalNumber = int.Parse(ReversToRealHexadecimalNumber(decimalStr));

            // step - 2: convert from decimal to given base (secondNumeralSystem)
            // using methods from task 3 - to 15 numeral system is simular to 16
            string reverseNumberInSNS = DecimalToHexadecimal.Program.DecimalToHexadecimalConversation(ref decimalNumber);
            string realNumberInSNS = DecimalToHexadecimal.Program.ReversToRealHexadecimalNumber(reverseNumberInSNS);

            Console.WriteLine("Representation of number {0} in {1} numeral system to {2} numeral system is : {3}."
                              , numberFromFNS, firstNumeralSystem, secondNumeralSystem, realNumberInSNS);
        }

        private static string ReversToRealHexadecimalNumber(string decimalStr)
        {
            string realDecimal = string.Empty;
            for (int i = decimalStr.Length - 1; i >= 0; i--)
            {
                realDecimal += decimalStr[i];
            }
            return realDecimal;
        }

        private static string FromGivenBaseToStringDecimalConversation(int numberFromFNS, int firstNumeralSystem)
        {
            int decimalInt = 0;
            string decimalNumTemp = "";

            while (numberFromFNS != 0)
            {
                decimalInt = numberFromFNS % firstNumeralSystem;
                string hexaStrTemp = decimalInt.ToString();
                numberFromFNS = numberFromFNS / firstNumeralSystem;

                decimalNumTemp += hexaStrTemp;
            }

            // note from autor
            // now int numberFromFNS is 0, but aftef using this method it will be again 210.
            // if you wanna numberFromFNS to change its result use "ref" in method
            // I explain this because we use this number in Console.WriteLine at the end.

            return decimalNumTemp;
        }
    }
}
