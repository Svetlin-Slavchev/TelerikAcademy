using System;

//task 3
//Write a static class with a static method to calculate the distance between two points in the 3D space.

namespace _1.StructPoint3D
{
    public static class Distance
    {
         public static double Calculate(Point3D pointOne, Point3D pointTwo)
        {
            // The formula is d=sqrt((x_2-x_1)^2+(y_2-y_1)^2+(z_2-z_1)^2).
            double distance = Math.Sqrt(Math.Pow(pointTwo.Xcord - pointOne.Xcord, 2) +
                Math.Pow(pointTwo.Ycord - pointOne.Ycord, 2) + Math.Pow(pointTwo.Zcord - pointOne.Zcord, 2));
            return distance;
        }
    }
}
