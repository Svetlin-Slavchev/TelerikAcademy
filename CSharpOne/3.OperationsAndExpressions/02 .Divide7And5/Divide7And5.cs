using System;
using System.Collections.Generic;
using System.Linq;

// Write a boolean expression that checks for given integer if it can be divided 
// (without remainder) by 7 and 5 in the same time.

class Divide7And5
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        if ((number % 5 == 0) && (number % 7 == 0))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
