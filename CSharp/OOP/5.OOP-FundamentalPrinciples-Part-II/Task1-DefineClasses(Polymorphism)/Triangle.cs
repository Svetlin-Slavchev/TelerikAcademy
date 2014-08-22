using System;

namespace _1.Task1_DefineClasses_Polymorphism_
{
    public class Triangle : Shape
    {
        public override double CalculateSurface(double widht, double height)
        {
            return (height * widht) / 2;
        }

        public Triangle()
        {
        }

        public Triangle(double widht, double height)
            : base (widht, height)
        {
        }
    }
}
