using System;
using System.Collections.Generic;
using System.Linq;

class GreedyDwarf
{
    static List<int> myList = new List<int>();

    static void Main(string[] args)
    {
        string[] valleystr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] valley = new int[valleystr.Length];
        for (int i = 0; i < valley.Length; i++)
        {
            valley[i] = int.Parse(valleystr[i]);
        }
        int patternNum = int.Parse(Console.ReadLine());

        for (int i = 0; i < patternNum; i++)
        {
            string[] patternStr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[patternStr.Length];
            for (int j = 0; j < pattern.Length; j++)
            {
                pattern[j] = int.Parse(patternStr[j]);
            }

            int coins = 0;
            bool[] visited = new bool[valley.Length];
            int position = 0;

            while ((position >= 0) && (position < valley.Length) && (visited[position] != true))
            {

                for (int j = 0; j < pattern.Length; j++)
                {
                    if ((position >= 0) && (position < valley.Length) && (visited[position] != true))
                    {
                        visited[position] = true;
                        coins += valley[position];
                        position += pattern[j];
                    }
                }
            }
            myList.Add(coins);
        }
        myList.Sort();
        Console.WriteLine(myList[myList.Count - 1]);
    }
}

