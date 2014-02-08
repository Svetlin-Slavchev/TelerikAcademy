using System;

// Tassk 8
// Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

namespace _8.GenericMatrix
{
    public class Matrix<T> where T : System.IComparable, System.IFormattable, System.IConvertible, System.IComparable<int>, System.IEquatable<int>
    {
        private const int dimension = 4;
        private T[,] matrix;

        public Matrix(int rows, int colls)
        {
            this.matrix = new T[rows, colls];
            this.Rows = rows;
            this.Colls = colls;
        }

        public int Rows
        {
            get { return Rows; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("The row must be positive a number!");
                }
                Rows = value;
            }
        }

         public int Colls
        {
            get { return Colls; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("The coll must be positive a number!");
                }
                Colls = value;
            }
        }

        // Task 9
        // Implement an indexer this[row, col] to access the inner matrix cells.

        public T this[int row, int coll]
        {
            get
            {
                return this.matrix[row, coll];
            }
            set
            {
                this.matrix[row, coll] = value;
            }
        }

        public int Lenght
        {
            get { return dimension; }
        }

        private Matrix<int>[,] m1 = new Matrix<int>[4, 4];
        private Matrix<int>[,] m2 = new Matrix<int>[4, 4];

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Colls != m2.Colls)
            {
                throw new ArgumentException("Invalid argument.Matrix must be equal!");
            }

            Matrix<T> newMatrix = new Matrix<T>(4, 4);
            for (int row = 0; row < m1.Rows; row++)
            {
                for (int coll = 0; coll < m1.Colls; coll++)
                {
                    newMatrix[row, coll] = (dynamic)m1[row, coll] + (dynamic)m2[row, coll];
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Colls != m2.Colls)
            {
                throw new ArgumentException("Invalid argument.Matrix must be equal!");
            }

            Matrix<T> newMatrix = new Matrix<T>(4, 4);
            for (int row = 0; row < m1.Rows; row++)
            {
                for (int coll = 0; coll < m1.Colls; coll++)
                {
                    newMatrix[row, coll] = (dynamic)m1[row, coll] - (dynamic)m2[row, coll];
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Colls != m2.Rows)
            {
                throw new ArgumentException("Invalid argument.Collums of first matrix must be equal to rows of second matrix!");
            }
            Matrix<T> newMatrix = new Matrix<T>(4, 4);
            int countRows = 0;
            int countColls = 0;

            for (int row = 0; row < m1.Rows; row++)
            {
                for (int coll = 0; coll < m1.Colls; coll++)
                {
                    newMatrix[row, coll] = ((dynamic)m1[row, coll - countRows] * (dynamic)m2[row - countColls, coll]) +
                        ((dynamic)m1[row, coll + 1 - countRows] * (dynamic)m2[row + 1 - countColls, coll]);
                    countRows++;
                }
                countColls++;
                countRows = 0;
            }
            return newMatrix;
        }

        public static Boolean operator true(Matrix<T> m1)
        {
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Colls; j++)
                {
                    if (m1[i, j].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static Boolean operator false(Matrix<T> m1)
        {
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Colls; j++)
                {
                    if (m1[i, j].Equals(default(T)))
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }
}
