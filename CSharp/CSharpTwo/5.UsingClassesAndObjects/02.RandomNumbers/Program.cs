﻿using System;

// Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace RandomNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next(100, 200));
            }
        }
    }
}
