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
        public virtual PointF Point1 { get; set; }
    }
    public class Point : Figure
    {
        public Point() : base()
        {
        }
        public Point(float X, float Y) : base()
        {
            PointF tmp = Point1;
            tmp.X = X;
            tmp.Y = Y;
            Point1 = tmp;
        }

        public override void Draw(Graphics painter) 
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            painter.DrawLine(penObj, Point1.X, Point1.Y, Point1.X + 2, Point1.Y);  
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
            painter.DrawLine(penObj, Point1.X, Point1.Y, Point1.X + lenX, Point1.Y - lenY);
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
            Point2.X = Point1.X + Side1.lenX;
            Point2.Y = Point1.Y - Side1.lenY;
            Point3.X = Point1.X + Side2.lenX;
            Point3.Y = Point1.Y - Side2.lenY;
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
                Point2.X = value.X + (Point2.X - Point1.X);
                Point2.Y = value.Y + (Point2.Y - Point1.Y);
                Point3.X = value.X + (Point3.X - Point1.X);
                Point3.Y = value.Y + (Point3.Y - Point1.Y);
                base.Point1 = value;
            } 
        }
        public PointF Point2;
        public PointF Point3;
    }

    public class RectTriangle : Triangle
    {
        public RectTriangle(Line Side1, Line Side2) : base(Side1, Side2)
        {
            Side2 = new Line(Side2.Length, (float)(Side1.Degree - Math.PI / 2));
            Point3.X = Point1.X + Side2.lenX;
            Point3.Y = Point1.Y - Side2.lenY;
        }

        public RectTriangle(float Leg1, float Leg2, float Degree)
        {
            Point2.X = (float)(Point1.X + Leg1 * Math.Cos((Math.PI / 2) + Degree));
            Point2.Y = (float)(Point1.Y - Leg1 * Math.Sin((Math.PI / 2) + Degree));
            Point3.X = (float)(Point1.X + Leg2 * Math.Cos(Degree));
            Point3.Y = (float)(Point1.Y - Leg2 * Math.Sin(Degree));
        }
    }

    public class RightTriangle : Triangle
    {
        public RightTriangle(Line Side)
        {
            Point2.X = (float)(Point1.X + Side.Length * Math.Cos((Math.PI / 3) + Side.Degree));
            Point2.Y = (float)(Point1.Y - Side.Length * Math.Sin((Math.PI / 3) + Side.Degree));
            Point3.X = (float)(Point1.X + Side.Length * Math.Cos(Side.Degree));
            Point3.Y = (float)(Point1.Y - Side.Length * Math.Sin(Side.Degree));
        }
    }

    public class Quadrangal : Figure
    {
        protected Quadrangal()
        {
        }

        public Quadrangal(PointF point1, PointF point2, PointF point3, PointF point4)
        {
            base.Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
        }

        public Quadrangal(PointF startPoint, Line vector1, Line vector2, Line vector3)
        {
            base.Point1 = startPoint;
            Point2 = new PointF((float)(Point1.X + vector1.Length * Math.Cos(vector1.Degree)), (float)(Point1.Y - vector1.Length * Math.Sin(vector1.Degree)));
            Point3 = new PointF((float)(Point2.X + vector2.Length * Math.Cos(vector2.Degree)), (float)(Point2.Y - vector2.Length * Math.Sin(vector2.Degree)));
            Point4 = new PointF((float)(Point3.X + vector3.Length * Math.Cos(vector3.Degree)), (float)(Point3.Y - vector3.Length * Math.Sin(vector3.Degree)));
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

    public class Ellipse : Figure
    {
        public Ellipse(PointF center, double radiusX, double radiusY, double rotationDegree)
        {
            Point1 = center;
            RadiusX = radiusX;
            RadiusY = radiusY;
            RotationDegree = rotationDegree;
        }

        public override void Draw(Graphics painter)
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            painter.DrawEllipse(penObj, (float)(Point1.X - RadiusX), (float)(Point1.Y - RadiusY), (float)(RadiusX * 2), (float)(RadiusY * 2));
            Brush brushObj = new SolidBrush(this.FillColor);
            painter.FillEllipse(brushObj, (float)(Point1.X - RadiusX), (float)(Point1.Y - RadiusY), (float)(RadiusX * 2), (float)(RadiusY * 2));
        }
        public double RadiusX { get; protected set; }
        public double RadiusY { get; protected set; }
        public double RotationDegree { get; protected set; }
    }
}


