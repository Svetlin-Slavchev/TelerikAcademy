using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//task 4
//Create a class Path to hold a sequence of points in the 3D space.

namespace _1.StructPoint3D
{
    public static class Path
    {
        private static List<Point3D> points = new List<Point3D>();

        public static void AddPoint(Point3D point)
        {
            points.Add(point);
        }

        public static string ShowPoints()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < points.Count; i++)
            {
                sb.Append(points[i]);
            }

            return sb.ToString();
        }
    }
}
