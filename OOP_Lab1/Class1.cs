using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab1
{
    public abstract class Figure
    {
        public Figure() 
        {
            this.FillColor = Color.Gray;
            this.BorderColor = Color.Black;
            this.BorderWidth = 2;
        }
        public abstract void Draw(Graphics painter);

        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }   
        public int BorderWidth { get; set; }
        public virtual PointF StartPoint { get; set; }
    }
    public class Point : Figure
    {
        public Point() : base()
        {
        }
        public Point(float X, float Y) : base()
        {
            PointF tmp = StartPoint;
            tmp.X = X;
            tmp.Y = Y;
            StartPoint = tmp;
        }

        public override void Draw(Graphics painter) 
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            painter.DrawLine(penObj, StartPoint.X, StartPoint.Y, StartPoint.X + 2, StartPoint.Y);  
        }
    }

    public class Line : Point
    {
        public Line(float Length, float Degree) : base()
        {
            lenX = (float)(Length * Math.Cos(Degree));
            lenY = (float)(Length * Math.Sin(Degree));
            this.Length = Length;
            this.Degree = Degree;
        }
        public Line(float X, float Y, float Length, float Degree) : base(X, Y)
        {
            lenX = (float)(Length * Math.Cos(Degree));
            lenY = (float)(Length * Math.Sin(Degree));
            this.Length = Length;
            this.Degree = Degree;
        }

        public override void Draw(Graphics painter)
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            painter.DrawLine(penObj, StartPoint.X, StartPoint.Y, StartPoint.X + lenX, StartPoint.Y - lenY);
        }

        public float lenX { get; protected set; }
        public float lenY { get; protected set; }
        public float Length { get; protected set; }
        public float Degree { get; protected set; }
    }

    public class Triangle : Figure
    {
        public Triangle()
        {
        }
        public Triangle(float X2, float Y2, float X3, float Y3) : base()
        {
            Point2.X = X2;
            Point2.Y = Y2;
            Point3.X = X3;  
            Point3.Y = Y3;
        }
        public Triangle(Line Side1, Line Side2) : base()
        {
            Point2.X = StartPoint.X + Side1.lenX;
            Point2.Y = StartPoint.Y - Side1.lenY;
            Point3.X = StartPoint.X + Side2.lenX;
            Point3.Y = StartPoint.Y - Side2.lenY;
        }
        public sealed override void Draw(Graphics painter)
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            PointF[] trianglePoints = {
                StartPoint,
                Point2,
                Point3
            };
            painter.DrawPolygon(penObj, trianglePoints);
            Brush brushObj = new SolidBrush(this.FillColor);
            painter.FillPolygon(brushObj, trianglePoints);
        }

        public override PointF StartPoint 
        { 
            get => base.StartPoint; 
            set 
            {
                Point2.X = value.X + (Point2.X - StartPoint.X);
                Point2.Y = value.Y + (Point2.Y - StartPoint.Y);
                Point3.X = value.X + (Point3.X - StartPoint.X);
                Point3.Y = value.Y + (Point3.Y - StartPoint.Y);
                base.StartPoint = value;
            } 
        }
        public PointF Point2;
        public PointF Point3;
    }

    public class RightTriangle : Triangle
    {
        public RightTriangle(Line Side1, Line Side2) : base(Side1, Side2)
        {
            Side2 = new Line(Side2.Length, (float)(Side1.Degree - Math.PI / 2));
            Point3.X = StartPoint.X + Side2.lenX;
            Point3.Y = StartPoint.Y - Side2.lenY;
        }

        public RightTriangle(float Leg1, float Leg2, float Degree)
        {
            Point2.X = (float)(StartPoint.X + Leg1 * Math.Cos((Math.PI / 2) + Degree));
            Point2.Y = (float)(StartPoint.Y - Leg1 * Math.Sin((Math.PI / 2) + Degree));
            Point3.X = (float)(StartPoint.X + Leg2 * Math.Cos(Degree));
            Point3.Y = (float)(StartPoint.Y - Leg2 * Math.Sin(Degree));
        }
    }
}


