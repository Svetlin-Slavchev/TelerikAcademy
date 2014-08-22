using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace PrintDivisibleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 12, 21, 35, 23, 42, 34 };

            // using Lamda expressions
            List<int> newArr = arr.ToList().FindAll(x => (x % 3 == 0) && (x % 7 == 0));

            foreach (int item in newArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // using LINQ
            var sortedNumbers =
                from x in arr
                where ((x % 3 == 0) && (x % 7 == 0))
                select x;

            foreach (var item in sortedNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
