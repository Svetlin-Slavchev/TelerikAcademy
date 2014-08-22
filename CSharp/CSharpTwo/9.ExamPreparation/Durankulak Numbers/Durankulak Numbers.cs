using System;
using System.Collections.Generic;
using System.Linq;

class DurankulakNumbers
{
    static void Main(string[] args)
    {
        string num = Console.ReadLine();
        List<string> myList = new List<string>();
        List<string> myListTwo = new List<string>();

        for (char i = 'A'; i <= 'Z'; i++)
        {
            myList.Add(i.ToString());
        }

        for (char i = 'a'; i <= 'f'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                myList.Add(i.ToString() + j.ToString());
            }
        }

        for (int i = 0; i < num.Length; i++)
        {
            if (char.IsUpper(num[i]))
            {
                if ((i == 0))
                {
                    myListTwo.Add(num[i].ToString());
                    continue;
                }
                else if (char.IsLower(num[i - 1]))
                {
                    string str = num[i - 1].ToString() + num[i].ToString();
                    myListTwo.Add(str);
                }
                else
                {
                    myListTwo.Add(num[i].ToString());
                }
            }
            else
            {
                continue;
            }
        }

        //myListTwo.Reverse();
        long sum = 0;
        for (int i = 0; i < myListTwo.Count; i++)
        {
            for (int j = 0; j < myList.Count; j++)
            {
                if (myList[j] == myListTwo[i])
                {
                    long digit = j;
                    //digit = digit * ((int)(Math.Pow(168, i)));
                    //sum += digit;
                    //continue;
                    sum = sum * 168 + digit;
                }
            }
        }
        Console.WriteLine(sum);
    }
}

