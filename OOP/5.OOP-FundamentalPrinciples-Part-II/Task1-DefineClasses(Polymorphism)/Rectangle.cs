using System;

namespace _1.Task1_DefineClasses_Polymorphism_
{
    public class Rectangle : Shape
    {
        public override double CalculateSurface(double widht, double height)
        {
            return widht * height;
        }

        public Rectangle()
        {
        }

        public Rectangle(double widht, double height)
            : base (widht, height)
        {
        }
    }
}
