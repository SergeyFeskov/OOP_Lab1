using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2
{
    public class Triangle : Figure
    {
        protected Triangle(PointF startPoint)
        {
            Point1 = startPoint;
        }

        public Triangle(float X1, float Y1, float X2, float Y2, float X3, float Y3) : base()
        {
            Point1 = new PointF(X1, Y1);
            Point2 = new PointF(X2, Y2);
            Point3 = new PointF(X3, Y3);
        }

        public Triangle(PointF point1, PointF point2, PointF point3) : base()
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }

        public Triangle(PointF startPoint, Vector side1, Vector side2) : base()
        {
            Point1 = startPoint;
            Point2 = new PointF(Point1.X + side1.X, Point1.Y - side1.Y);
            Point3 = new PointF(Point1.X + side2.X, Point1.Y - side2.Y);
        }

        public sealed override void Draw(Graphics painter)
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            PointF[] trianglePoints = {
                Point1,
                Point2,
                Point3
            };
            painter.DrawPolygon(penObj, trianglePoints);
            Brush brushObj = new SolidBrush(this.FillColor);
            painter.FillPolygon(brushObj, trianglePoints);
        }

        public override PointF Point1
        {
            get => base.Point1;
            set
            {
                Point2 = new PointF(value.X + (Point2.X - Point1.X), value.Y + (Point2.Y - Point1.Y));
                Point3 = new PointF(value.X + (Point3.X - Point1.X), value.Y + (Point3.Y - Point1.Y));
                base.Point1 = value;
            }
        }
        public PointF Point2 { get; set; }
        public PointF Point3 { get; set; }
    }
}
