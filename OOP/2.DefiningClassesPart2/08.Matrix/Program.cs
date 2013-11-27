using System;

namespace MatrixDefinition
{
    class Program
    {
        static readonly Random rand = new Random();

        static void Main(string[] args)
        {
            Matrix<int> matrixOne = new Matrix<int>(4, 4);
            Console.WriteLine("First matrix:");
            for (int i = 0; i < matrixOne.Rows; i++)
            {
                for (int j = 0; j < matrixOne.Colls; j++)
                {
                    Console.Write((matrixOne[i, j] = rand.Next(20)) + " ");
                }
                Console.WriteLine();
            }

            Matrix<int> matrixTwo = new Matrix<int>(4, 4);
            Console.WriteLine("Second matrix");
            for (int i = 0; i < matrixTwo.Rows; i++)
            {
                for (int j = 0; j < matrixTwo.Colls; j++)
                {
                    Console.Write((matrixTwo[i, j] = rand.Next(20)) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("First matrix: {0}", matrixOne ? "Whitout zero!" : "Whit zero elements!");
            Console.WriteLine("Second matrix: {0}", matrixTwo ? "Whitout zero!" : "Whit zero elements!");
            Console.WriteLine();

            Matrix<int> matrixThree = new Matrix<int>(4, 4);
            Console.WriteLine("Matrixs addition:");
            for (int i = 0; i < matrixTwo.Rows; i++)
            {
                for (int j = 0; j < matrixTwo.Colls; j++)
                {
                    Console.Write(matrixOne[i, j] + matrixTwo[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Matrix subtraction:");
            for (int i = 0; i < matrixTwo.Rows; i++)
            {
                for (int j = 0; j < matrixTwo.Colls; j++)
                {
                    Console.Write(matrixOne[i, j] - matrixTwo[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Matrix multiplication:");
            for (int i = 0; i < matrixTwo.Rows; i++)
            {
                for (int j = 0; j < matrixTwo.Colls; j++)
                {
                    Console.Write(matrixOne[i, j] * matrixTwo[i, j] + " ");
                }
                Console.WriteLine();
            }
        }       
    }
}
