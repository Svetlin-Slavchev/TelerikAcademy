using System;
using System.Text;

// task 1
//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
//Implement the ToString() to enable printing a 3D point.

namespace _1.StructPoint3D
{
    public struct Point3D
    {
        private double xcord;
        private double ycord;
        private double zcord;

        //task 2
        //Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        //Add a static property to return the point O.
        private static readonly Point3D center;

        public static Point3D Center
        {
            get { return new Point3D(0, 0, 0); }
        }

        public Point3D(double xcord, double ycord, double zcord)
            : this()
        {
            this.Xcord = xcord;
            this.Ycord = ycord;
            this.Zcord = zcord;
        }

        public double Xcord
        {
            get { return xcord; }
            set 
            { 
                if (value < 0)
                {
                    throw new FormatException("The Xcord must be a positive number!");
                }
                xcord = value; 
            }
        }

        public double Ycord
        {
            get { return ycord; }
            set 
            { 
                if (value < 0)
                {
                    throw new FormatException("The Ycord must be a positive number!");
                }
                ycord = value; 
            }
        }

        public double Zcord
        {
            get { return zcord; }
            set 
            { 
                if (value < 0)
                {
                    throw new FormatException("The Zcord must be a positive number!");
                }
                zcord = value; 
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("( {0}, {1}, {2} )", this.Xcord, this.Ycord, this.Zcord);

            return result.ToString();
        }
    }
}
