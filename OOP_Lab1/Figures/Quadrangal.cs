using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab1
{
    public class Quadrangal : Figure
    {
        protected Quadrangal(PointF startPoint)
        {
            base.Point1 = startPoint;
        }

        public Quadrangal(PointF point1, PointF point2, PointF point3, PointF point4)
        {
            base.Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
        }

        // gets quadrangal cords with its point and vectors, which 'describe' quadrangal's polyline from given point 
        public Quadrangal(PointF startPoint, Vector vector1, Vector vector2, Vector vector3)
        {
            base.Point1 = startPoint;
            Point2 = new PointF(Point1.X + vector1.X, Point1.Y - vector1.Y);
            Point3 = new PointF(Point2.X + vector2.X, Point2.Y - vector2.Y);
            Point4 = new PointF(Point3.X + vector3.X, Point3.Y - vector3.Y);
        }

        public sealed override void Draw(Graphics painter)
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            PointF[] quadrangalPoints = {
                Point1,
                Point2,
                Point3,
                Point4
            };
            painter.DrawPolygon(penObj, quadrangalPoints);
            Brush brushObj = new SolidBrush(this.FillColor);
            painter.FillPolygon(brushObj, quadrangalPoints);
        }

        public sealed override PointF Point1
        {
            get => base.Point1;
            set
            {
                Point2 = new PointF(value.X + (Point2.X - Point1.X), value.Y + (Point2.Y - Point1.Y));
                Point3 = new PointF(value.X + (Point3.X - Point1.X), value.Y + (Point3.Y - Point1.Y));
                Point4 = new PointF(value.X + (Point4.X - Point1.X), value.Y + (Point4.Y - Point1.Y));
                base.Point1 = value;
            }
        }
        public PointF Point2 { get; protected set; }
        public PointF Point3 { get; protected set; }
        public PointF Point4 { get; protected set; }
    }
}
