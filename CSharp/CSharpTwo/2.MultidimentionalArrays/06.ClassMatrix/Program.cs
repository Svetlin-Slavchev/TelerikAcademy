using System;

// * Write a class Matrix, to holds a matrix of integers. Overload the operators for adding,
// subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

namespace ClassMatrix
{
    public class Program
    {
        static readonly Random rand = new Random(); // this is random generator

        static void Main(string[] args)
        {
            Matrix matrixOne = new Matrix(4, 4);
            Console.WriteLine("First matrix:");
            PrintMatrix(matrixOne);

            Console.WriteLine();

            Matrix matrixTwo = new Matrix(4, 4);
            Console.WriteLine("Second matrix");
            PrintMatrix(matrixTwo);

            Console.WriteLine();

            Console.WriteLine("Matrix addition:");
            MatrixAddition(matrixTwo, matrixOne);

            Console.WriteLine();

            Console.WriteLine("Matrix subtraction:");
            MatrixSubtraction(matrixTwo, matrixOne);

            Console.WriteLine();

            Console.WriteLine("Matrix multiplication:");
            MatrixMultiplication(matrixTwo, matrixOne);
        }
  
        private static void MatrixMultiplication(Matrix matrixTwo, Matrix matrixOne)
        {
            for (int i = 0; i < matrixTwo.Rows; i++)
            {
                for (int j = 0; j < matrixTwo.Colls; j++)
                {
                    Console.Write(matrixOne[i, j] * matrixTwo[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
  
        private static void MatrixSubtraction(Matrix matrixTwo, Matrix matrixOne)
        {
            for (int i = 0; i < matrixTwo.Rows; i++)
            {
                for (int j = 0; j < matrixTwo.Colls; j++)
                {
                    Console.Write(matrixOne[i, j] - matrixTwo[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
  
        private static void MatrixAddition(Matrix matrixTwo, Matrix matrixOne)
        {
            for (int i = 0; i < matrixTwo.Rows; i++)
            {
                for (int j = 0; j < matrixTwo.Colls; j++)
                {
                    Console.Write(matrixOne[i, j] + matrixTwo[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // print matrix whit random numbers
        private static Matrix PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Colls; j++)
                {
                    Console.Write((matrix[i, j] = rand.Next(20)) + " ");
                }
                Console.WriteLine();
            }

            return matrix;
        }
    }
}

