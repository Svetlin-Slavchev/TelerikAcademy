using System;
using System.Collections.Generic;
using System.Linq;

namespace Structure3DPoint
{
    // Create a class Path to hold a sequence of points in the 3D space. 
    // Create a static class PathStorage with static methods to save and load paths from a text file.
    // Use a file format of your choice.

   public class Path
    {
       public List<Point3D> points = new List<Point3D>();

       public void Points(List<Point3D> points)
       {
           points.Add(new Point3D(4.5, 5, 6.2));
           points.Add(new Point3D(5.2, 8, 9.5));
           points.Add(new Point3D(8, 8, 12.4));
       }
    }
}
