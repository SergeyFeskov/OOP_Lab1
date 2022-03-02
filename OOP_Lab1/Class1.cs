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
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Point : Figure
    {
        public Point() : base()
        {
        }
        public Point(int X, int Y) : base()
        {
            this.X = X;
            this.Y = Y;
        }

        public override void Draw(Graphics painter) 
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            painter.DrawLine(penObj, X, Y, X + 2, Y);  
        }
    }

    public class Line : Point
    {
        public Line(int Length) : base()
        {
            this.Length = Length;
        }
        public Line(int X, int Y, int Length) : base(X, Y)
        {
            this.Length = Length;
        }

        public override void Draw(Graphics painter)
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            painter.DrawLine(penObj, X, Y, X + this.Length, Y);
        }

        public int Length { get; protected set; }
    }

    public class Triangle : Figure
    {
        public Triangle(int X2, int Y2, int X3, int Y3) : base()
        {
            this.X2 = X2;
            this.Y2 = Y2;
            this.X3 = X3;
            this.Y3 = Y3;
        }

        public override void Draw(Graphics painter)
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            PointF[] trianglePoints = {
                new PointF(this.X, this.Y),
                new PointF(this.X2, this.Y2),
                new PointF(this.X3, this.Y3)
            };
            painter.DrawPolygon(penObj, trianglePoints);
            Brush brushObj = new SolidBrush(this.FillColor);
            painter.FillPolygon(brushObj, trianglePoints);
        }

        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }
    }
}


