using System;

// Write a program that prints all posible cards from a stndard deck of 52 cards(wihtout jokers). The cards should be printed 
// whit their English names. Use nested for loops and switch case.

class Program
{
    static void Main()
    {

        for (int i = 1; i <= 13; i++)
        {
            for (int k = 1; k <= 4; k++)
            {
                switch (i)
                {
                    case 1: Console.Write("Deuce of "); break;
                    case 2: Console.Write("Three of "); break;
                    case 3: Console.Write("Four of "); break;
                    case 4: Console.Write("Five of "); break;
                    case 5: Console.Write("Six of "); break;
                    case 6: Console.Write("Seven of "); break;
                    case 7: Console.Write("Eight of "); break;
                    case 8: Console.Write("Nine of "); break;
                    case 9: Console.Write("Ten of "); break;
                    case 10: Console.Write("Jack of "); break;
                    case 11: Console.Write("Queen of "); break;
                    case 12: Console.Write("King of "); break;
                    case 13: Console.Write("Ace of "); break;
                    default:
                        break;
                }

                switch (k)
                {
                    case 1: Console.WriteLine("Spades"); break;
                    case 2: Console.WriteLine("Hearts"); break;
                    case 3: Console.WriteLine("Diamonds"); break;
                    case 4: Console.WriteLine("Clubs"); break;
                    default:
                        break;
                }
            }
        }
    }
}

