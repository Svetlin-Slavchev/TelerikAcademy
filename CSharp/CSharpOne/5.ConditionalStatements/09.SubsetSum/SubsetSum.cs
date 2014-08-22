// using System;

//   We are given five integer numbers. Write a program that checks if the sum of some subset of them is 0. 
//   Example: 3,-2, 1, 1, 8  -> 1 + 1 - 2 = 0.


// class Program                  //  FIRST SOLUTION WIHT ARRAYS - WORK ONLY WITH CONSECUTIVE SUBSET
// {
//    static void Main()
//    {
//        int[] array = new int[5]; // Using array 
//
//       for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write("Enter a number: ");
//            array[i] = int.Parse(Console.ReadLine());
//       }
//
//       int sum = 0;
//
//        for (int i = 0; i < array.Length; i++)
//        {
//            sum += array[i];
//
//            if (sum == 0)
//           {
//                Console.WriteLine("Sum = " + sum);
//                break;
//            }
//
//       }
//        Console.WriteLine("There  is no subset = 0 !");
//    }
// }  




using System;             // SECOND SOLUTION - WORK FINE, BUT IS TOO LONG

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entr number for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Entr number for b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Entr number for c: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Entr number for d: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Entr number for e: ");
        int e = int.Parse(Console.ReadLine());

        if (a + b == 0)
        {
            Console.WriteLine("The sum of a and b = 0");
        }

        if (a + c == 0)
        {
            Console.WriteLine("The sum of a and c = 0");
        }

        if (a + d == 0)
        {
            Console.WriteLine("The sum of a and d = 0");
        }

        if (a + e == 0)
        {
            Console.WriteLine("The sum of a and e = 0");
        }

        if (b + c == 0)
        {
            Console.WriteLine("The sum of b and c = 0");
        }

        if (b + d == 0)
        {
            Console.WriteLine("The sum of b and d = 0");
        }

        if (b + e == 0)
        {
            Console.WriteLine("The sum of b and e = 0");
        }

        if (c + d == 0)
        {
            Console.WriteLine("The sum of c and d = 0");
        }

        if (c + e == 0)
        {
            Console.WriteLine("The sum of c and e = 0");
        }

        if (d + e == 0)
        {
            Console.WriteLine("The sum of d and e = 0");
        }

        if (a + b + c == 0)
        {
            Console.WriteLine("The sum of a, b and c = 0");
        }

        if (a + b + d == 0)
        {
            Console.WriteLine("The sum of a, b and d = 0");
        }

        if (a + b + e == 0)
        {
            Console.WriteLine("The sum of a, b and e = 0");
        }

        if (a + c + d == 0)
        {
            Console.WriteLine("The sum of a, c and d = 0");
        }

        if (a + c + e == 0)
        {
            Console.WriteLine("The sum of a, c and e = 0");
        }

        if (a + d + e == 0)
        {
            Console.WriteLine("The sum of a, d and e = 0");
        }

        if (b + c + d == 0)
        {
            Console.WriteLine("The sum of b, c and d = 0");
        }

        if (b + d + e == 0)
        {
            Console.WriteLine("The sum of b, d and e = 0");
        }

        if (b + c + e == 0)
        {
            Console.WriteLine("The sum of b, c and e = 0");
        }

        if (c + d + e == 0)
        {
            Console.WriteLine("The sum of c, d and e = 0");
        }

        if (a + b + c + d == 0)
        {
            Console.WriteLine("The sum of a, b, c and d = 0");
        }

        if (a + b + c + e == 0)
        {
            Console.WriteLine("The sum of a, b, c and e = 0");
        }

        if (a + b + d + e == 0)
        {
            Console.WriteLine("The sum of a, b, d and e = 0");
        }

        if (a + c + d + e == 0)
        {
            Console.WriteLine("The sum of a, c, d and e = 0");
        }

        if (b + c + d + e == 0)
        {
            Console.WriteLine("The sum of b, c, d and e = 0");
        }

        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("The sum of a, b, c, d and e = 0");
        }
    }
}





