using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometryMySolution.NewClassesByMe
{
    public class Circle : Figure, IAreaMeasurable, IFlat
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public Circle(Vector3D center, double radius)
            : base(center)
        {
            this.Radius = radius;
        }

        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public Vector3D GetNormal()
        {
            return new Vector3D(0, 0, 1);
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetArea();
        }
    }
}
