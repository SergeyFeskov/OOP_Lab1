using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2.Drawers
{
    public class QuadrangalDrawer : Drawer
    {
        public QuadrangalDrawer(Graphics painter, DrawerSettings drawerSettings) : base(painter, drawerSettings)
        { }

        public override bool Handles(Figure figure)
        {
            return figure is Quadrangal;
        }

        public override void Draw(Figure figure)
        {
            Quadrangal quadrangal = (Quadrangal)figure;
            Pen penObj = new Pen(Settings.BorderColor, Settings.BorderWidth);
            PointF[] quadrangalPoints = {
                quadrangal.Point1,
                quadrangal.Point2,
                quadrangal.Point3,
                quadrangal.Point4
            };
            Painter.DrawPolygon(penObj, quadrangalPoints);
            Brush brushObj = new SolidBrush(Settings.FillColor);
            Painter.FillPolygon(brushObj, quadrangalPoints);
        }
    }
}
