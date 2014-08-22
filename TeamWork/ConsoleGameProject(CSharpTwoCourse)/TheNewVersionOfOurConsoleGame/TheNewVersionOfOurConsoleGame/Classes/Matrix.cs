using System;
using TheNewVersionOfOurConsoleGame.Interfaces;
using System.IO;
using System.Linq;

namespace TheNewVersionOfOurConsoleGame.Classes
{
    public class Matrix : IRenderable, ILoad
    {
        public Matrix(int matrixDimension)
        {
            this.MatrixDimension = matrixDimension;
            this.Row = Row;
            this.Coll = Coll;
        }

        public int SelectorIndexRow { get; set; }
        public int SelectorIndexColl { get; set; }
        public int[,] matrix;
        public int Row{ get; private set;}
        public int Coll{ get; private set;}
        public int MatrixDimension { get; private set; }

        public void Render(int coordinateX, int coordinateY, int[,] matrix, int matrixDimension)
        {
            for (int row = 0; row < MatrixDimension; row++)
            {
                Console.SetCursorPosition(coordinateX, coordinateY - 5 + row * 2);
                for (int col = 0; col < MatrixDimension; col++)
                {
                    if (row >= SelectorIndexRow && row <= (SelectorIndexRow + 1) && col >= SelectorIndexColl && col <= (SelectorIndexColl + 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write("{0,4}", this.matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public int[,] Load(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            int width;
            int height;
            //reads the first value in the text file. It is the width of the matrix
            int.TryParse(reader.ReadLine(), out width);
            //reads the second value in the text file. It is the hight of the matrix
            int.TryParse(reader.ReadLine(), out height);
            int[,] matrix = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int.TryParse(reader.ReadLine(), out matrix[i, j]);
                }
            }
            reader.Close();
           return matrix;
        }

        public void Save(int[,] testValues, string fileName) /// static void Save(int[,] testValues, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(this.matrix.GetLength(0));
            writer.WriteLine(this.matrix.GetLength(1));

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    writer.WriteLine(this.matrix[i, j]);
                }
            }
            writer.Close();
        }

        public int[,] Inicialize(int matrixDimention)
        {
            Random rand = new Random();
            int[] myArray = new int[this.MatrixDimension * this.MatrixDimension]; // ??? is 0??
            for (int i = 0; i < myArray.Length; i++)
            {
               myArray[i] = i + 1;
            }

            myArray = myArray.OrderBy(x => rand.Next()).ToArray();
            int count = 0;

            matrix = new int[MatrixDimension, MatrixDimension];
            for (int j = 0; j < MatrixDimension; j++)
            {
                for (int k = 0; k < MatrixDimension; k++)
                {
                   matrix[j, k] = myArray[count];
                    count++;
                }
            }

            // int[,] matrix = {
            //                   {6,5, 3, 4}, 
            //                   {2, 1, 7,8},
            //                   {9, 10, 11, 12}, 
            //                   {13, 14, 15,16}
            //                 };
            return matrix;
        }

        public void MoveAntyClockWiseNumbersOrderInSelector(int[,] matrix)
        {
            int temp = matrix[SelectorIndexRow, SelectorIndexColl];
            int temp2 = matrix[SelectorIndexRow + 1, SelectorIndexColl];
            int temp3 = matrix[SelectorIndexRow + 1, SelectorIndexColl + 1];
            int temp4 = matrix[SelectorIndexRow, SelectorIndexColl + 1];

            matrix[SelectorIndexRow, SelectorIndexColl] = temp4;
            matrix[SelectorIndexRow + 1, SelectorIndexColl] = temp;
            matrix[SelectorIndexRow + 1, SelectorIndexColl + 1] = temp2;
            matrix[SelectorIndexRow, SelectorIndexColl + 1] = temp3;
        }

        public void SelectorMove(string direction, int matrixDimention)
        {
            if (direction.CompareTo("right") == 0)
            {
                if (SelectorIndexColl < MatrixDimension - 2)
                {
                    SelectorIndexColl += 1;
                }
            }
            else if (direction.CompareTo("left") == 0)
            {
                if (SelectorIndexColl >= 1)
                {
                    SelectorIndexColl -= 1;
                }
            }
            else if (direction.CompareTo("up") == 0)
            {
                if (SelectorIndexRow >= 1)
                {
                    SelectorIndexRow -= 1;
                }
            }
            else if (direction.CompareTo("down") == 0)
            {
                if (SelectorIndexRow < MatrixDimension - 2)
                {
                    SelectorIndexRow += 1;
                }
            }
        }
    }
}
