using System;

// Declare two string variables and assign them with “Hello” and “World”. 
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
// Declare a third string variable and initialize it with the value of the object variable 
// (you should perform type casting).

class DeclareString
{
    static void Main(string[] args)
    {
        string FirstWord = "Hello";
        string SecondWord = "World";
        object greetings = FirstWord + " " + SecondWord;
        string greetings2 = FirstWord + SecondWord;
        Console.WriteLine("{0}", greetings);
        Console.WriteLine("{0}", greetings2);
    }
}
