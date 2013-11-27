using System;

// Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
// Define two new classes Triangle and Rectangle that implement the virtual method
// and return the surface of the figure (height*width for rectangle and height*width/2 for triangle).
// Define class Circle and suitable constructor so that at initialization height must be kept equal
// to width and implement the CalculateSurface() method.
// Write a program that tests the behavior of  the CalculateSurface() method for different shapes
// (Circle, Rectangle, Triangle) stored in an array.

namespace _1.Task1_DefineClasses_Polymorphism_
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] arr = {
                              new Rectangle(8, 5),
                              new Triangle(5, 6),
                              new Circle(5, 5)
                          };

            for (int i = 0; i < arr.Length; i++)
            {
                // tests the behavior of the CalculateSurface() method 
                Console.WriteLine(arr[i].CalculateSurface(arr[i].Widht, arr[i].Height));
            }
        }
    }
}
