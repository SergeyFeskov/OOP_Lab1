using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2.Drawers
{
    public class EllipseDrawer : Drawer
    {
        public EllipseDrawer(Graphics painter, DrawerSettings drawerSettings) : base(painter, drawerSettings)
        { }

        public override bool Handles(Figure figure)
        {
            return figure is Ellipse;
        }

        public override void Draw(Figure figure)
        {
            Ellipse ellipse = (Ellipse)figure;
            Pen penObj = new Pen(Settings.BorderColor, Settings.BorderWidth);
            Painter.DrawEllipse(penObj, (float)(ellipse.Point1.X - ellipse.RadiusX),
                                    (float)(ellipse.Point1.Y - ellipse.RadiusY),
                                    (float)(ellipse.RadiusX * 2), (float)(ellipse.RadiusY * 2));
            Brush brushObj = new SolidBrush(Settings.FillColor);
            Painter.FillEllipse(brushObj, (float)(ellipse.Point1.X - ellipse.RadiusX), (float)(ellipse.Point1.Y - ellipse.RadiusY), (float)(ellipse.RadiusX * 2), (float)(ellipse.RadiusY * 2));
        }
    }
}
