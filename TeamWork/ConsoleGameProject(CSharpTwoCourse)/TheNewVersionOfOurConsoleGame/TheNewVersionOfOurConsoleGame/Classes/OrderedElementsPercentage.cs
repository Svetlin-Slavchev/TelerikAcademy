using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNewVersionOfOurConsoleGame.Interfaces;

namespace TheNewVersionOfOurConsoleGame.Classes
{
    public class OrderedElementsPercentage : IPrintable
    {
        //public Matrix[,] matrix;
        public int PercentageOfOrderedElemnts { get; set; }

        public OrderedElementsPercentage()
        {
        }

        public int Check(int[,] matrix, int matrixDimention) /// private static int CheckOrderedElementsPercentage(int[,] matrix)
        {
            // int matrixDimention = matrix.GetLength(0);
            int currentOrderedElement = 0;
            int countOrderedElements = 0;
            for (int row = 0; row < matrixDimention; row++)
            {
                for (int col = 0; col < matrixDimention; col++)
                {
                    currentOrderedElement++;
                    if (matrix[row, col] == currentOrderedElement)
                    {
                        countOrderedElements++;
                    }
                }
            }
            int orderedElementPercetage = (countOrderedElements * 100) / (int)Math.Pow(matrixDimention, 2);
            return orderedElementPercetage;
        }

        public void Print(TimeSpan RemainingTime,int coordinateX, int coordinateY)
        {
            Console.SetCursorPosition(coordinateX, coordinateY);
            Console.WriteLine("Ordered: {0}%", PercentageOfOrderedElemnts);
        }
    }
}
