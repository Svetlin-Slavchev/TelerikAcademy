using System;

// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

namespace TriangleSurface
{
    public class Program
    {
        static void Main(string[] args)
        {
            double sideA = 5;
            double sideB = 6;
            double sideC = 4;
            double altitudeA = 7;
            double angleC = 90;
            //double perimetar = 0;
            //double surfaseOfTriangle = 0;
            Console.WriteLine("Surface of triangle");
            Console.WriteLine("- by side and altitude is {0:0.00}."
                , SurfaceOfTriangleBySideAndAndAltitude(sideA, altitudeA));
            Console.WriteLine("- by three sides is {0:0.00}."
                , SurfaceOfTriangleByThreeSide(sideA, sideB, sideC));
            Console.WriteLine("- by two sides and angle between them {0:0.00}."
                , SurfaceOfTriangleByTwoSideAndAngleBetweenThem(sideA, sideB, angleC));
        }

        static double SurfaceOfTriangleBySideAndAndAltitude(double sideA, double altitudeA)
        {
            // S = ½(a.ha) = ½(b.hb) = ½(c.hc)
            double surfaseOfTriangle = (sideA * altitudeA) / 2;
            return surfaseOfTriangle;
        }

        static double SurfaceOfTriangleByThreeSide(double sideA, double sideB, double sideC)
        {
            // p = ½(a + b + c) - find Perimetar
            // S = √p(p - a)(p - b)(p - c) - Heron's formula
            double perimetar = (sideA + sideB + sideC) / 2;
            double surfaseOfTriangle = Math.Sqrt(perimetar * (perimetar - sideA) * (perimetar - sideB) * (perimetar - sideC));
            return surfaseOfTriangle;
        }

        static double SurfaceOfTriangleByTwoSideAndAngleBetweenThem(double sideA, double sideB, double angleC)
        {
            // S = ½(ab.sinC) = ½(ac.sinB) = ½(bc.sinA)
            double a = Math.Sin(angleC);
            double surfaseOfTriangle = (sideA * sideB * Math.Sin(angleC)) / 2;
            return surfaseOfTriangle;
        }
    }
}
