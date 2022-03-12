using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2.Drawers
{
    public class PointDrawer : Drawer
    {
        public PointDrawer(Graphics painter, DrawerSettings drawerSettings) : base(painter, drawerSettings)
        { }

        public override bool Handles(Figure figure)
        {
            return figure is Point;
        }

        public override void Draw(Figure figure)
        {
            Pen penObj = new Pen(this.Settings.BorderColor, this.Settings.BorderWidth);
            this.Painter.DrawLine(penObj, figure.Point1.X, figure.Point1.Y, figure.Point1.X + 1, figure.Point1.Y);
        }
    }
}
