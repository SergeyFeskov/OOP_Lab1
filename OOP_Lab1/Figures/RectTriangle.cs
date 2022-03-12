using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2
{
    public class RectTriangle : Triangle
    {
        public RectTriangle(PointF startPoint, Vector side1, Vector side2) : base(startPoint, side1, side2)
        {
            side2 = new Vector(side2.GetLength(), side1.GetDegree() - Math.PI / 2);
            Point3 = new PointF(Point1.X + side2.X, Point1.Y - side2.Y);
        }

        public RectTriangle(PointF startPoint, Vector leg1Vector, float leg2Length) : base(startPoint)
        {
            Point2 = new PointF((float)(Point1.X + leg1Vector.X),
                                (float)(Point1.Y - leg1Vector.Y));
            Point3 = new PointF((float)(Point1.X + leg2Length * Math.Cos(leg1Vector.GetDegree() + (Math.PI / 2))),
                                (float)(Point1.Y - leg2Length * Math.Sin(leg1Vector.GetDegree() + (Math.PI / 2))));
        }
    }
}
