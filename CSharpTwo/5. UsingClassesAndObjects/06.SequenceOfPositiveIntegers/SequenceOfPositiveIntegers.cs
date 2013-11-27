using System;

// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.  
// Example: string = "43 68 9 23 318"  result = 461

class SequenceOfPositiveIntegers
{
    static void Main(string[] args)
    {
        int sum = 0;
        string num = "21 34 56 23";
        string[] splitNumbers = num.Split(' ');
        Console.WriteLine("The sum split numbers is {0}.", SumOfSplitNumbers(splitNumbers, sum));
    }

    static int SumOfSplitNumbers(string[] splitNumbers, int sum)
    {
        foreach (var number in splitNumbers)
        {
            sum += int.Parse(number);
        }
        return sum;
    }
}

