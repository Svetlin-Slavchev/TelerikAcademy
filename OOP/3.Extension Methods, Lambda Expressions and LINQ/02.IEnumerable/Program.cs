using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() {1, 4, 5};
            Console.WriteLine(myList.Sum());
            Console.WriteLine(myList.Min());
            Console.WriteLine(myList.Max());
            Console.WriteLine(myList.Average());
            Console.WriteLine(myList.Product());
            Console.WriteLine();

            List<string> myListTwo = new List<string>() {"ala", "bala", "portokala"};
            Console.WriteLine(myListTwo.Sum());
            Console.WriteLine(myListTwo.Min());
            Console.WriteLine(myListTwo.Max());
        }
    }
}
