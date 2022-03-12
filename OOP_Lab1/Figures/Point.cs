using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2
{
    public class Point : Figure
    {
        public Point(PointF startPoint) : base()
        {
            Point1 = startPoint;
        }

        public Point(float X, float Y) : base()
        {
            Point1 = new PointF(X, Y);
        }

        public override void Draw(Graphics painter)
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            painter.DrawLine(penObj, Point1.X, Point1.Y, Point1.X + 1, Point1.Y);
        }
    }
}
