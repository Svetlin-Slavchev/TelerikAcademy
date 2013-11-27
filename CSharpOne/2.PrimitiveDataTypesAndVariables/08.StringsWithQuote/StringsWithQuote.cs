using System;

// Declare two string variables and assign them with following value:
// Do the above in two different ways: with and without using quoted strings.

class StringsWithQuote
{
    static void Main(string[] args)
    {
        string FirstType = "The \"use\" of quotations causes difficulties";
        string SecondType = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine("{0}", FirstType);
        Console.WriteLine("{0}", SecondType);
    }
}
