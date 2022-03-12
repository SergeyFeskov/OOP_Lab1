using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2
{
    public class Line : Figure
    {
        public Line(PointF startPoint, Vector vector) : base()
        {
            Point1 = startPoint;
            LineVector = vector;
        }

        public Line(PointF startPoint, float length, float degree) : base()
        {
            Point1 = startPoint;
            LineVector = new Vector(length, (double)degree);
        }      

        public Vector LineVector { get; set; }
    }
}
