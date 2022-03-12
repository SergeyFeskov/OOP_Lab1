using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2
{
    public class Circle : Ellipse
    {
        public Circle(PointF center, double radius)
        {
            Point1 = center;
            RadiusX = radius;
            RadiusY = radius;
        }
    }
}
