using System;

// Write a program that, depending of the user's choice inputs int, double or string variable. If the variable is integer or double, 
// increases whit 1. If the variable is string, apends "*" at its end. The program must show the value of that variable as a console output.
// Use switch statement.

class Program
{
static void Main()
{
        
    Console.WriteLine("Write a number depending of your choice: 0 for int, 1 for double or 2 for string types");
    byte inputNumber =byte.Parse(Console.ReadLine());
       

    switch (inputNumber)
    {
        case 0:                
            Console.WriteLine(inputNumber + 1);
            break;
        case 1:
            Console.WriteLine(inputNumber + 1);
            break;
        case 2:
            string input = Convert.ToString(inputNumber);
            Console.WriteLine(input + '*');
            break;
        default:
            Console.WriteLine("Error");
            break;
    }
}
}

