using System;
using System.Text;

namespace Structure3DPoint
{
    // Task 1:
    // Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
    // Implement the ToString() to enable printing a 3D point.
    public struct Point3D
    {
        private double Xcordinate;
        private double Ycordinate;
        private double Zcordinate;

        // Task 2:
        // Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        // Add a static property to return the point O.
        private static readonly Point3D pointZero = new Point3D(0, 0, 0);

        public static Point3D PointZero
        {
            get { return pointZero; }
        }
        
        public double XCordinate
        {
            get { return Xcordinate; }
            set { Xcordinate = value; }
        }

        public double YCordinate
        {
            get { return Ycordinate; }
            set { Ycordinate = value; }
        }

        public double ZCordinate
        {
            get { return Zcordinate; }
            set { Zcordinate = value; }
        }

        public Point3D(double Xcordinate, double Ycordinate, double Zcordinate) : this()
        {
            this.Xcordinate = Xcordinate;
            this.Ycordinate = Ycordinate;
            this.Zcordinate = Zcordinate;
        }

        public override string ToString()
        {
            StringBuilder allPoints = new StringBuilder();
            allPoints.AppendFormat("Point X: {0}", this.Xcordinate);
            allPoints.AppendLine();
            allPoints.AppendFormat("Point Y: {0}", this.Ycordinate);
            allPoints.AppendLine();
            allPoints.AppendFormat("Point Z: {0}", this.Zcordinate);
            return allPoints.ToString();
        }        
    }
}
