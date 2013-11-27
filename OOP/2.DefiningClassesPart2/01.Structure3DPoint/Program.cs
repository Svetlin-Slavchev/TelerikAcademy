using System;
using System.Collections.Generic;

namespace Structure3DPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point3D> points = new List<Point3D>();
            Path path = new Path();
            
            path.Points(points);
            PathStorage.SavePath(points);

            Console.WriteLine(PathStorage.LoadPath());

            Console.WriteLine("Distance is : {0}.", DistanceBetweenTwoPoints.CalculateDistanceBetweenTwoPoint
                (new Point3D(3, 5, 7), new Point3D(5, 7, 9)));
        }
    }
}
