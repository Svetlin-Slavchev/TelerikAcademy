using System;

namespace ClassMatrix
{
    public class Matrix
    {
        public Matrix(int row, int coll)
        {
            this.Rows = row;
            this.Colls = coll;
            this.matrix = new int[row, coll];
        }

        private int rows;
        private int colls;
        private readonly int[,] matrix;

        //TODO: validation!
        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public int Colls
        {
            get { return colls; }
            set { colls = value; }
        }

        // implement indexer
        public int this[int row, int coll]
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
         
        private Matrix[,] m1 = new Matrix[4, 4];
        private Matrix[,] m2 = new Matrix[4, 4];

        // implement adding
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Colls != m2.Colls)
            {
                throw new ArgumentException("Invalid argument.Matrix must be equal!");
            }

            Matrix newMatrix = new Matrix(4, 4);
            for (int row = 0; row < m1.Rows; row++)
            {
                for (int coll = 0; coll < m1.Colls; coll++)
                {
                    newMatrix[row, coll] = m1[row, coll] + m2[row, coll];
                }
            }
            return newMatrix;
        }

        // implement subtracting
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Colls != m2.Colls)
            {
                throw new ArgumentException("Invalid argument.Matrix must be equal!");
            }

            Matrix newMatrix = new Matrix(4, 4);
            for (int row = 0; row < m1.Rows; row++)
            {
                for (int coll = 0; coll < m1.Colls; coll++)
                {
                    newMatrix[row, coll] = m1[row, coll] - m2[row, coll];
                }
            }
            return newMatrix;
        }

        // implement multiplying
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Colls != m2.Rows)
            {
                throw new ArgumentException("Invalid argument.Collums of first matrix must be equal to rows of second matrix!");
            }
            Matrix newMatrix = new Matrix(4, 4);
            int countRows = 0;
            int countColls = 0;

            for (int row = 0; row < m1.Rows; row++)
            {
                for (int coll = 0; coll < m1.Colls; coll++)
                {
                    newMatrix[row, coll] = ((m1[row, coll - countRows] * m2[row - countColls, coll]) +
                        (m1[row, coll + 1 - countRows] * m2[row + 1 - countColls, coll]));
                    countRows++;
                }
                countColls++;
                countRows = 0;
            }
            return newMatrix;
        }

        // override ToString()
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
