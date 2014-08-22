using System;

namespace _1.Task1_DefineClasses_Polymorphism_
{   
    public class Circle : Shape
    {
        public override double CalculateSurface(double widht, double height)
        {
            // if widht == height, that is radius of the circle
            if (widht == height)
            {
                return Math.PI * widht * height; // PI * r ^ 2 
            }
            else
            {
                throw new ArgumentException("This is not a circle!");
            }
        }

        public Circle()
        {
        }

        public Circle(double widht, double height)
            : base (widht, height)
        {
        }
    }
}
