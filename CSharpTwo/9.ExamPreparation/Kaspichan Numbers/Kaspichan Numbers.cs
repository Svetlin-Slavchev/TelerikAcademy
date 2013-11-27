using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class KaspichanNumbers
{
    static void Main(string[] args)
    {
        ulong n = ulong.Parse(Console.ReadLine());
        List<string> myList = new List<string>();

        for (char i = 'A'; i <= 'Z'; i++)
        {
            myList.Add(i.ToString());
        }

        for (char i = 'a'; i <= 'i'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                myList.Add(i.ToString() + j.ToString());
            }
        }

        if (n <= 255)
        {
            string newN = myList[(int)n];
            Console.WriteLine(newN);
        }
        else
        {
            string result = "";
            while (n != 0)
            {
                result = myList[(int)(n % 256)] + result;
                n = n / 256;
            }
            Console.WriteLine(result);
        }
    }
}
