using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab1
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

        public override void Draw(Graphics painter)
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            painter.DrawEllipse(penObj, (float)(Point1.X - RadiusX), 
                                (float)(Point1.Y - RadiusY), 
                                (float)(RadiusX * 2), (float)(RadiusY * 2));
            Brush brushObj = new SolidBrush(this.FillColor);
            painter.FillEllipse(brushObj, (float)(Point1.X - RadiusX), (float)(Point1.Y - RadiusY), (float)(RadiusX * 2), (float)(RadiusY * 2));
        }
        public double RadiusX { get; protected set; }
        public double RadiusY { get; protected set; }
    }
}
