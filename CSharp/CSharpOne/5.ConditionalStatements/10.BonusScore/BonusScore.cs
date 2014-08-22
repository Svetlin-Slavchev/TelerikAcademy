using System;

// Write a program that applice bonus scores to given scores in the range[1..9]. The program reads a digit as an input. If the digit is between
// 1 and 3, the program multiplies it by 10. If it is between 4 and 6, multiplies it by 100. If it is between 7 and 9, multiplies it by 1000. 
// If it is a zero or if the valuee is not a digit, the program must report an error. 
// Use switch statement and at the end print the calculated new value in the console.

class Program
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        int scores = int.Parse(Console.ReadLine());

        switch (scores)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine(scores * 10);
                Console.WriteLine(scores + (scores * 10));
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine(scores * 100);
                Console.WriteLine(scores + (scores * 100));
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine(scores * 1000);
                Console.WriteLine(scores + (scores * 1000));
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
        
    }
}

