using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNewVersionOfOurConsoleGame.Classes;

namespace TheNewVersionOfOurConsoleGame
{
    public class MainProgram
    {
        public const int MaxHeight = 40;
        public const int MaxWidth = 70;
        public static string fileName = @"Save.txt";
        public static bool loadSavedGame = false;
        public string direction;

        public static bool LoadSavedGame
        {
            get { return loadSavedGame; }
            set { loadSavedGame = value; }
        }

        static void Main(string[] args)
        {
            Matrix newMatrix = new Matrix(4);
           // int[,] matrix = new int[newMatrix.MatrixDimension, newMatrix.MatrixDimension];
            Timer timer = new Timer(10);
            OrderedElementsPercentage elements = new OrderedElementsPercentage();
            while (true)
            {
              
                PrintMenues.Settings();

                Console.BufferHeight = Console.WindowHeight = MaxHeight;
                Console.BufferWidth = Console.WindowWidth = MaxWidth;

                PrintMenues.Menu();
                PrintMenues.HelpMenu();

                if (LoadSavedGame == false)
                {
                    newMatrix.Inicialize(newMatrix.MatrixDimension);
                    //newMatrix.Render(Console.WindowWidth / 2 - 25, Console.WindowHeight / 2, matrix, newMatrix.MatrixDimension);
                    timer.MaxTime = TimeSpan.FromMinutes(timer.gameTimeOutInMinutes);
                    timer.RemainingTime = timer.MaxTime;
                }
                else
                {
                    newMatrix.matrix = newMatrix.Load(fileName);
                    int[] savedRemainingTime = timer.Load(timer.timerFileName);
                    timer.MaxTime = TimeSpan.FromMinutes(savedRemainingTime[0]) + TimeSpan.FromSeconds(savedRemainingTime[1]);
                    timer.RemainingTime = timer.MaxTime;
                }
         
                DateTime startTime = DateTime.Now;

                bool endOfGame = true;
                while ((timer.RemainingTime.Minutes >= 0 && timer.RemainingTime.Seconds >= 0 && elements.PercentageOfOrderedElemnts < 100))
                {
                   // newMatrix.Load(fileName);
                    elements.PercentageOfOrderedElemnts = elements.Check(newMatrix.matrix, 4);
                    newMatrix.Render(Console.WindowWidth / 2 - 25, Console.WindowHeight / 2, newMatrix.matrix, 4);
                    //  TimeSpan playedTime = CalculateTimeFromStart();
                    timer.RemainingTime = timer.CalculateRemainingTime(timer.MaxTime, startTime);

                   timer.Print(timer.RemainingTime, Console.WindowWidth - 26, Console.WindowHeight - 30);
                    elements.Print(timer.RemainingTime, Console.WindowWidth - 26, Console.WindowHeight - 32);

                    try
                    {
                        ConsoleKeyInfo pressedKeys = default(ConsoleKeyInfo);
                        if (Console.KeyAvailable)
                        {
                            pressedKeys = Console.ReadKey();
                            if (pressedKeys.Key == ConsoleKey.Spacebar)
                            {
                                newMatrix.MoveAntyClockWiseNumbersOrderInSelector(newMatrix.matrix);
                            }
                            else if (pressedKeys.Key == ConsoleKey.RightArrow)
                            {
                                newMatrix.SelectorMove("right", newMatrix.MatrixDimension);
                            }
                            else if (pressedKeys.Key == ConsoleKey.LeftArrow)
                            {
                                newMatrix.SelectorMove("left", newMatrix.MatrixDimension);
                            }
                            else if (pressedKeys.Key == ConsoleKey.UpArrow)
                            {
                                newMatrix.SelectorMove("up", newMatrix.MatrixDimension);
                            }
                            else if (pressedKeys.Key == ConsoleKey.DownArrow)
                            {
                                newMatrix.SelectorMove("down", newMatrix.MatrixDimension);
                            }
                            else if (pressedKeys.Key == ConsoleKey.S)
                            {
                                newMatrix.Save(newMatrix.matrix, fileName);
                                timer.Save(timer.timerFileName);
                                endOfGame = false;
                                Console.Clear();
                                break;
                            }

                            else if (pressedKeys.Key == ConsoleKey.D)
                            {
                                Console.Clear();
                                PrintMenues.HelpMenu();
                                PrintMenues.PrintHelpMenu();
                            }
                            else if (pressedKeys.Key == ConsoleKey.H)
                            {
                                PrintMenues.PrintHelpMenu();
                                Console.Clear();
                                PrintMenues.HelpMenu();
                            }
                            else
                            {
                                throw new InvalidOperationException();
                            }
                        }
                    }
                    catch (InvalidOperationException)
                    {
                        Console.Clear();
                        PrintMenues.HelpMenu();
                        continue;
                    }
                }

                Console.Clear();

                if (elements.PercentageOfOrderedElemnts == 100)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(30, Console.WindowHeight / 2 - 6);
                    Console.WriteLine("YOU WIN!!!");
                    Console.SetCursorPosition(13, Console.WindowHeight / 2 - 4);
                    Console.WriteLine("The puzel is {0}% ordered for {1} minutes!",
                        elements.PercentageOfOrderedElemnts, timer.CalculateTimeFromStart(timer.MaxTime, timer.RemainingTime));
                    Console.SetCursorPosition(8, Console.WindowHeight / 2 + 10);
                    break;
                }
                else if (endOfGame == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(30, Console.WindowHeight / 2 - 6);
                    Console.WriteLine("GAME OVER!!!");
                    Console.SetCursorPosition(13, Console.WindowHeight / 2 - 4);
                    Console.WriteLine("The puzel is {0}% ordered for {1} minutes!",
                        elements.PercentageOfOrderedElemnts, timer.CalculateTimeFromStart(timer.MaxTime, timer.RemainingTime));
                    Console.SetCursorPosition(8, Console.WindowHeight / 2 + 10);
                }
                else
                {
                    Console.SetCursorPosition(Console.BufferWidth / 2 - 6, Console.WindowHeight / 2 - 6);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Game saved");
                }
            }      
        }    
    }
}
