using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheNewVersionOfOurConsoleGame.Classes
{
    public class PrintMenues
    {
         public static void Settings() // global environment settings
        {
            Console.Title = "..::: OrderNumberGame :::.."; // game name in console bar
            Console.CursorVisible = false; // cursur deactivated
        }

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 - 3);
            Console.WriteLine("..::: ORDER NUMBER GAME :::..");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 1);
            Console.WriteLine("Commands:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2);
            Console.WriteLine("to START new game - type \"start\"");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 + 1);
            Console.WriteLine("to LOAD saved game - type \"load\"");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 12, Console.WindowHeight / 2 + 2);
            Console.WriteLine("for EXIT - type \"exit\"");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 + 3);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Enter command here:");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.WindowHeight / 2 + 4);
            string command = Console.ReadLine();

            try
            {
                if ((command != "start") && (command != "load") && (command != "exit"))
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 13, Console.WindowHeight / 2 + 7);
                Console.WriteLine("Invalid command! Try again!");
                Thread.Sleep(800);
                Console.Clear();
                Menu();
            }

            if (command == "exit")
            {
                Environment.Exit(0);
            }
            else if (command == "load")
            {
                Settings();
                Console.Clear();
                MainProgram.LoadSavedGame = true;
            }

            Console.Clear();
        }

        public static void HelpMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2);
            Console.WriteLine("to SHOW Help menu press \"D\"");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 1);
            Console.WriteLine("to HIDE Help Menu press \"H\"");
        }

        public static void PrintHelpMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 3);
            Console.WriteLine("To MOVE press ARROW keys");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 4);
            Console.WriteLine("To ROTATE numbers press SPACE BAR");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 5);
            Console.WriteLine("To SAVE and exit game press \"S\"");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 6);
            Console.WriteLine("GAMEPLAY: The main objective of the");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 7);
            Console.WriteLine("game is to arrange the numbers in");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 8);
            Console.WriteLine("sequence from top to bottom,");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 9);
            Console.WriteLine("before the time is out!");
        }
    }  
}
