using System;
using System.Collections.Generic;
using System.Linq;

// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

class Brackets
{
    static void Main(string[] args)
    {
        string expression = "((a+b)/5-d)";
        string expressionTwo = ")(a+b))";
        List<string> myList = new List<string> { expression, expressionTwo };

        for (int i = 0; i < myList.Count; i++)
        {
            int countOne = 1;
            int countTwo = 1;
            int index = myList[i].IndexOf("(");
            int indexTwo = myList[i].IndexOf(")");
            while (true)
            {
                index = myList[i].IndexOf("(", index + 1);
                indexTwo = myList[i].LastIndexOf(")", indexTwo + 1);
                if ((index == -1) || (indexTwo == -1))
                {
                    break;
                }
                countOne++;
                countTwo++;
                if ((index == 0) && (indexTwo == expression.Length - 1) || (countOne == countTwo))
                {
                    Console.WriteLine("Expression {0} is corect!", myList[i]);
                }
            }

            if ((countOne != countTwo) || (index == expression.Length - 1) || (indexTwo == 0))
            {
                Console.WriteLine("Expression {0} is not corect!", myList[i]);
            }
        }
    }
}
