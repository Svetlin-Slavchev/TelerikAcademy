using System;
using System.Collections.Generic;
using System.Linq;

// We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements 
// of the array that has a sum S. Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

class Program
{
    static void Main(string[] args)
    {
        int n = 8;
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int sum = 14;
      //  int n = int.Parse(Console.ReadLine());
      // int[] arr = new int[n];
      //  for (int i = 0; i < n; i++)
      //  {
      //      arr[i] = int.Parse(Console.ReadLine());
      //  }

      // int sum = int.Parse(Console.ReadLine());

        List<int> mylist = new List<int>();
        int maxSubset = (int)Math.Pow(2, n) - 1;
        int currentSum = 0;
        int count = 0;
        
        for (int i = 1; i <= maxSubset; i++)
        {
            currentSum = 0;
            for (int j = 1; j <= arr.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentSum += arr[j - 1];
                    mylist.Add(arr[j - 1]);
                }
            }

            if (currentSum == sum)
            {
                count++;
                for (int m = 0; m < mylist.Count; m++)
                {
                    Console.Write(mylist[m] + " ");
                }
                Console.WriteLine();
            }
 
            mylist.Clear();
        }
        if (count == 0)
            {
                Console.WriteLine("There is no subset equal to {0}", sum);
            }
    }
}

