using System;

// Write a program to check if in a given expression the brackets are put correctly.// Example of correct expression: ((a+b)/5-d).// Example of incorrect expression: )(a+b)).

namespace IsBracketsCorect
{
    public class Program
    {
        static void Main(string[] args)
        {
            string expression = "((a+b)/5-d)";

            char firstChar = '(';
            char secondChar = ')';
            int firstSelectedCharIndex = expression.IndexOf('(');
            int secondSelectedCharIndex = expression.IndexOf(')');
            int firstCount = 0;
            int secondCount = 0;

            CountOccurrencesOfSearchingChar(expression, ref firstSelectedCharIndex, ref firstCount, firstChar);
            CountOccurrencesOfSearchingChar(expression, ref secondSelectedCharIndex, ref secondCount, secondChar);

            if (firstCount == secondCount)
            {
                Console.WriteLine("Is this expression is correct? --> {0}", true);
            }
            else
            {
                Console.WriteLine("Is this expression is correct? --> {0}", false);
            }
        }

        private static void CountOccurrencesOfSearchingChar(string expression, ref int selectedChar, ref int firstCount, char searchingChar)
        {
            while (selectedChar != -1)
            {
                selectedChar = expression.IndexOf(searchingChar, selectedChar + 1);
                firstCount++;
            }
        }
    }
}
