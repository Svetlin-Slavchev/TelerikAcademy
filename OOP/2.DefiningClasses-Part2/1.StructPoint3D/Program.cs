using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StructPoint3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Path.AddPoint(new Point3D(1.6, 2, 4));
            Path.AddPoint(new Point3D(1, 3.8, 4));
            Path.AddPoint(new Point3D(1.5, 5, 4.4));

            PathStorage.Save();
            // read file and show points
            Console.WriteLine(PathStorage.Read());
        }
    }
}
