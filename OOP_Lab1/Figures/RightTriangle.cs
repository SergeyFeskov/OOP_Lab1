using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab1
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(PointF startPoint, Vector sideVector) : base(startPoint)
        {
            Point2 = new PointF((float)(Point1.X + sideVector.GetLength() * Math.Cos((Math.PI / 3) + sideVector.GetDegree())),
                                (float)(Point1.Y - sideVector.GetLength() * Math.Sin((Math.PI / 3) + sideVector.GetDegree())));
            Point3 = new PointF(Point1.X + sideVector.X, Point1.Y - sideVector.Y);
        }
    }
}
