﻿using System;

// Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).// Example: The target substring is "in". The text is as follows:// We are living in an yellow submarine. We don't have anything else. // Inside the submarine is very tight. So we are drinking all the day. // We will move out of it in 5 days.// The result is: 9.
namespace CountContainingSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else." +
                "Inside the submarine is very tight. So we are drinking all the day." +
                "We will move out of it in 5 days.";

            int index = text.IndexOf("in");
            int count = 1;

            while (index != -1)
            {
                index = text.IndexOf("in", index + 1);
                count++;
            }

            Console.WriteLine("Result is: {0}.", count);
        }
    }
}
