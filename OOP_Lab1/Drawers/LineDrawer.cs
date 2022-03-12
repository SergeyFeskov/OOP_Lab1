using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2.Drawers
{
    public class LineDrawer : Drawer
    {
        public LineDrawer(Graphics painter, DrawerSettings drawerSettings) : base(painter, drawerSettings)
        { }

        public override bool Handles(Figure figure)
        {
            return figure is Line;
        }

        public override void Draw(Figure figure)
        {
            Line line = (Line)figure;
            Pen penObj = new Pen(Settings.BorderColor, Settings.BorderWidth);
            Painter.DrawLine(penObj, line.Point1.X, line.Point1.Y, line.Point1.X + line.LineVector.X, line.Point1.Y - line.LineVector.Y);
        }
    }
}
