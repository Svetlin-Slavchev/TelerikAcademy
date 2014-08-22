using System;

namespace _1.Task1_DefineClasses_Polymorphism_
{
    public abstract class Shape
    {
        private double widht;
        private double height;

        public double Widht
        {
            get { return widht; }
            set { widht = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Shape()
        {
        }

        public Shape(double widht, double height)
        {
            this.Widht = widht;
            this.Height = height;
        }

        public abstract double CalculateSurface(double widht, double height);                  
    }
}
