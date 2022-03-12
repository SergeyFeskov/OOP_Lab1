using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2
{
    public class Ellipse : Figure
    {
        protected Ellipse()
        {
        }

        public Ellipse(PointF center, double radiusX, double radiusY)
        {
            Point1 = center;
            RadiusX = radiusX;
            RadiusY = radiusY;
        }

        public double RadiusX { get; protected set; }
        public double RadiusY { get; protected set; }
    }
}
