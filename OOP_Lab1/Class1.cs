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
        public Figure() { }
        public abstract void Draw(Graphics painter);

        public Color FillColor { get; protected set; }
        public Color BorderColor { get; protected set; }   
        public int BorderWidth { get; protected set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Point : Figure
    {
        public Point() { }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override void Draw(Graphics painter) 
        {
            Pen penObj = new Pen(Color.Black);
            painter.DrawLine(penObj, X, Y, X+10, Y+10);  
        }
    }

    public class Line : Point
    {
        public Line(int X, int Y, int Length) : base(X, Y)
        {
            this.Length = Length;
        }

        public int Length { get; protected set; }
    }
}
