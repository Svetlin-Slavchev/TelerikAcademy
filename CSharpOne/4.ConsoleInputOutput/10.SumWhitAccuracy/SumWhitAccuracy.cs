using System;

// Write a program to calculate the sum(whit accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 ....

class SumWhitAccuracy
{
    static void Main()
    {
        decimal counter = 2m;
        decimal sum = 1m;
        int sign = 1;
        while (1m / counter > 0.001m)
        {
            sum = sum + (1m / counter) * sign;
            sign = sign * (-1);
            counter++;
        }
        Console.WriteLine("sum = {0:0.000}", sum);
    }
}

