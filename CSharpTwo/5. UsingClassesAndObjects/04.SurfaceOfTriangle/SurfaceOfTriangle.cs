using System;

// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class SurfaceOfTriangle
{
    static void Main(string[] args)
    {
        double sideA = 5;
        double sideB = 6;
        double sideC = 4;
        double altitudeA = 7;
        double angleC = 35;
        double perimetar = 0;
        double surfaseOfTriangle = 0;
        Console.WriteLine("Surface of triangle");
        Console.WriteLine("- by side and altitu is {0}."
            , SurfaceOfTriangleBySideAndAndAltitude(sideA, altitudeA, surfaseOfTriangle));
        Console.WriteLine("- by three sides is {0}."
            , SurfaceOfTriangleByThreeSide(sideA, sideB, sideC, perimetar, surfaseOfTriangle));
        Console.WriteLine("- by two sides and angle between them {0}."
            , SurfaceOfTriangleByTwoSideAndAngleBetweenThem(sideA, sideB, angleC, surfaseOfTriangle));
    }

    static double SurfaceOfTriangleBySideAndAndAltitude(double sideA, double altitudeA, double surfaseOfTriangle)
    {
        // S = ½(a.ha) = ½(b.hb) = ½(c.hc)
        surfaseOfTriangle = (sideA * altitudeA) / 2;
        return surfaseOfTriangle;
    }

    static double SurfaceOfTriangleByThreeSide(double sideA, double sideB, double sideC, double perimetar, double surfaseOfTriangle)
    {
        //  p = ½(a + b + c) - find Perimetar
        //  S = √p(p - a)(p - b)(p - c) - Heron's formula
        perimetar = (sideA + sideB + sideC) / 2;
        surfaseOfTriangle = Math.Sqrt(perimetar * (perimetar - sideA) * (perimetar - sideB) * (perimetar - sideC));
        return surfaseOfTriangle;
    }

    static double SurfaceOfTriangleByTwoSideAndAngleBetweenThem(double sideA, double sideB, double angleC, double surfaseOfTriangle)
    {
        // S = ½(ab.sinC) = ½(ac.sinB) = ½(bc.sinA)
        surfaseOfTriangle = (sideA * sideB * Math.Sin(angleC)) / 2;
        return surfaseOfTriangle;
    }
}

