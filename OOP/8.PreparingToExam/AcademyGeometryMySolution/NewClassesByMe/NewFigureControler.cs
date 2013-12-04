using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometryMySolution.NewClassesByMe
{
    public class NewFigureControler : FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {
            switch (splitFigString[0])
            {
                case "circle":
                     {
                         Vector3D center = Vector3D.Parse(splitFigString[1]);
                         double radius = double.Parse(splitFigString[2]);
                         currentFigure = new Circle(center, radius);
                         break;
                     }
                case "cylinder":
                     {
                         Vector3D bottom = Vector3D.Parse(splitFigString[1]);
                         Vector3D top = Vector3D.Parse(splitFigString[2]);
                         double radius = double.Parse(splitFigString[3]);
                         currentFigure = new Cylinder(bottom, top, radius);
                         break;
                     }
                case "vertex":
                    {
                        Vector3D location = Vector3D.Parse(splitFigString[1]);
                        currentFigure = new Vertex(location);
                        break;
                    }
                case "segment":
                    {
                        Vector3D a = Vector3D.Parse(splitFigString[1]);
                        Vector3D b = Vector3D.Parse(splitFigString[2]);
                        currentFigure = new LineSegment(a, b);
                        break;
                    }
                case "triangle":
                    {
                        Vector3D a = Vector3D.Parse(splitFigString[1]);
                        Vector3D b = Vector3D.Parse(splitFigString[2]);
                        Vector3D c = Vector3D.Parse(splitFigString[3]);
                        currentFigure = new Triangle(a, b, c);
                        break;
                    }
            }

            this.EndCommandExecuted = false;
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            {
                case "area":
                    {
                        if (currentFigure is IAreaMeasurable)
                        {
                            double area = (this.currentFigure as IAreaMeasurable).GetArea();
                            if (area != null)
                            {
                                Console.WriteLine("{0:0.00}", area);
                            }
                            else
                            {
                                Console.WriteLine("undefined");
                            }
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "volume":
                    {
                        if (currentFigure is IVolumeMeasurable)
                        {
                            double volume = (this.currentFigure as IVolumeMeasurable).GetVolume();
                            if (volume != null)
                            {
                                Console.WriteLine("{0:0.00}", volume);
                            }
                            else
                            {
                                Console.WriteLine("undefined");
                            }
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "normal":
                    {
                        if (currentFigure is IFlat)
                        {
                            Vector3D normal = (this.currentFigure as IFlat).GetNormal();
                            if (normal != null)
                            {
                                Console.WriteLine("{0:0.00}", normal);
                            }
                            else
                            {
                                Console.WriteLine("undefined");
                            }
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "translate":
                    {
                        Vector3D transVector = Vector3D.Parse(splitCommand[1]);
                        this.currentFigure.Translate(transVector);
                        break;
                    }
                case "rotate":
                    {
                        Vector3D center = Vector3D.Parse(splitCommand[1]);
                        double degrees = double.Parse(splitCommand[2]);
                        this.currentFigure.RotateInXY(center, degrees);
                        break;
                    }
                case "scale":
                    {
                        Vector3D center = Vector3D.Parse(splitCommand[1]);
                        double factor = double.Parse(splitCommand[2]);
                        this.currentFigure.Scale(center, factor);
                        break;
                    }
                case "center":
                    {
                        Vector3D figCenter = this.currentFigure.GetCenter();
                        Console.WriteLine(figCenter.ToString());
                        break;
                    }
                case "measure":
                    {
                        Console.WriteLine("{0:0.00}", this.currentFigure.GetPrimaryMeasure());
                        break;
                    }
            }
        }
    }
}
