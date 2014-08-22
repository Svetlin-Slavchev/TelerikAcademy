using System;

// Write an if statments that examines two integer variables and exchance their values if the first one is greater then the second one.

class Program
{
    static void Main()
    {
        Console.Write("Enter a First number: ");
        int firstnumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a Second number: ");
        int secondnumber = int.Parse(Console.ReadLine());
        int thirtnumber = firstnumber;

        if (firstnumber > secondnumber)
        {
            firstnumber = secondnumber;
            secondnumber = thirtnumber;
            Console.WriteLine();
            Console.WriteLine("NewFirst number is: " + firstnumber);
            Console.WriteLine("NewSecond number is: "+ secondnumber);
        }

    }
}

