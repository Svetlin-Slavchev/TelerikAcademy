using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Structure3DPoint
{
    // Create a class Path to hold a sequence of points in the 3D space.
    // Create a static class PathStorage with static methods to save and load paths from a text file.
    // Use a file format of your choice.

    public static class PathStorage
    {
        public static void SavePath(List<Point3D> points)
        {
            StreamWriter writer = new StreamWriter("test.txt");
            using (writer)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    writer.WriteLine("Point {0} is - ({1}, {2}, {3})", i + 1, points[i].XCordinate, points[i].YCordinate,
                                                               points[i].ZCordinate);
                }                                                            
            }
        }

        public static string LoadPath()
        {
            StreamReader reader = new StreamReader("test.txt");
            string text = "";
            using (reader)
            {
                text = reader.ReadToEnd();
            }
            return text;
        }
    }
}
