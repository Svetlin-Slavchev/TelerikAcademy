using System;

// Write a program that reads an integer number and calculates and prints its square root. 
// If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

namespace SquareRoot
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "-5";
            // string input = "5";
            double number;

            try
            {
                bool isNumber = double.TryParse(input, out number);

                if (!isNumber || number < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    double result = Math.Sqrt(number);
                    Console.WriteLine("{0:0.00}", result);
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
