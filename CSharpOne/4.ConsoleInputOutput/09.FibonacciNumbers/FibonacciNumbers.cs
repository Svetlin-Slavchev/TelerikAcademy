using System;

// Write a program to print the first 100 members of the sequence of Fibonacci: 0,1,1,2,3,5,8,13,21,34,55,89,144,233,377... 

class FibonacciNumbers
{
    static void Main()
    {
        decimal member1 = 0m;
        decimal member2 = 1m;
        for (int counter = 0; counter <= 100; counter++)
        {
            Console.WriteLine(member1);
            decimal sum = member1 + member2;
            member1 = member2;
            member2 = sum;
        }
    }
}

