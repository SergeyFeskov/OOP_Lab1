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
    }
}
