using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyGeometryMySolution
{
    public class Vertex : Figure
    {
        public Vector3D Location
        {
            get { return this.vertices[0]; }
            set { this.vertices[0] = value; }
        }

        public Vertex(Vector3D location)
            : base(location)
        {
        }

        public override double GetPrimaryMeasure()
        {
            return 0;
        }
    }
}
