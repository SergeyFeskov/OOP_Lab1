using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2
{
    public abstract class Figure
    {
        public Figure()
        {
            this.FillColor = Color.LimeGreen;
            this.BorderColor = Color.Black;
            this.BorderWidth = 2;
        }

        public abstract void Draw(Graphics painter);

        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }
        public int BorderWidth { get; set; }
        public virtual PointF Point1 { get; set; }
    }
}
