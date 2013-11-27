using System;

namespace Structure3DPoint
{
    // Task 3:
    // Write a static class with a static method to calculate the distance between two points in the 3D space.
    public static class DistanceBetweenTwoPoints
    {
        public static double CalculateDistanceBetweenTwoPoint(Point3D pointOne, Point3D pointTwo)
        {
            // The formula is  d=sqrt((x_2-x_1)^2+(y_2-y_1)^2+(z_2-z_1)^2). 
            double distance = Math.Sqrt(Math.Pow(pointTwo.XCordinate - pointOne.XCordinate, 2) + 
                Math.Pow(pointTwo.YCordinate - pointOne.YCordinate, 2) + Math.Pow(pointTwo.ZCordinate - pointOne.ZCordinate, 2));
            return distance;
        }
    }
}
