using System;

// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
// If an invalid number or non-number text is entered, the method should throw an exception. 
// Using this method write a program that enters 10 numbers:
//	a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace ReadNumberMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = ReadNumber(0, 20);

                for (int i = 0; i < 10; i++)
                {
                    number = ReadNumber(number, 101);
                    Console.WriteLine(number);
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
        }

        private static int ReadNumber(int start, int end)
        {
            Random rand = new Random();
            System.Threading.Thread.Sleep(20);
            int number = rand.Next(start, end);


            if (number < start && number > end)
            {
                throw new ArgumentException();
            }

            return number;
        }
    }
}
