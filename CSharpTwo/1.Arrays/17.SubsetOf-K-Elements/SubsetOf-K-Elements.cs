using System;
using System.Collections.Generic;
using System.Linq;

//* Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence

class Subsets
{
    static void Main(string[] args)
    {
        int n = 8;                                     // number for N
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };          
        int sum = 5;                                   // for S
        int k = 2;                                     // for K
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

            if ((currentSum == sum) && (k == mylist.Count))
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



