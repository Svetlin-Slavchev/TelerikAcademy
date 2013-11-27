using System;

// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

class ExchangeValues
{
    static void Main(string[] args)
    {
        byte a = 5;
        byte b = 10;
        byte c;
        Console.WriteLine(a);
        Console.WriteLine(b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
