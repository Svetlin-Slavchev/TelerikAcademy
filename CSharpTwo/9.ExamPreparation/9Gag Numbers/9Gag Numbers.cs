using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NineGagNumbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] arr = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

        StringBuilder sb = new StringBuilder();
        List<string> myList = new List<string>();

        for (int i = 0; i < input.Length; i++)
        {
            sb.Append(input[i]);
            foreach (var item in arr)
            {
                if (item == sb.ToString())
                {
                    myList.Add(item);
                    sb.Clear();
                }
            }
        }

        // asking myself - myList.Reverse(); ?????
        ulong sum = 0;
        for (int i = 0; i < myList.Count; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == myList[i])
                {
                    ulong digit = (ulong)j;
                    sum = sum * 9 + digit;
                }
            }
        }

        Console.WriteLine(sum);
    }
}

