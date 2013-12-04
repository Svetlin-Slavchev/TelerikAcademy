using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometryMySolution.NewClassesByMe
{
    public class Cylinder : Figure, IVolumeMeasurable, IAreaMeasurable
    {
        public Cylinder(Vector3D bottomCenter, Vector3D topCenter, double radius)
            : base(bottomCenter, topCenter)
        {
            this.Radius = radius;
        }

        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double GetTopArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public double Height()
        {
            return (this.vertices[1] - this.vertices[0]).Magnitude;
        }

        public double GetArea()
        {
            double Perimetur = 2 * Math.PI * this.radius;
            double cylinderHeight = this.Height();
            double EnvironmentalSurfaceArea = Perimetur * cylinderHeight;
            double topAndBottomArea = 2 * this.GetTopArea();

            return EnvironmentalSurfaceArea + topAndBottomArea;
        }

        public double GetVolume()
        {
            return this.GetTopArea() * this.Height();
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetVolume();
        }
    }
}
