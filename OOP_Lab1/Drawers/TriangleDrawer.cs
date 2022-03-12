using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2.Drawers
{
    public class TriangleDrawer : Drawer
    {
        public TriangleDrawer(Graphics painter, DrawerSettings drawerSettings) : base(painter, drawerSettings)
        { }

        public override bool Handles(Figure figure)
        {
            return figure is Triangle;
        }

        public override void Draw(Figure figure)
        {
            Triangle triangle = (Triangle)figure;
            Pen penObj = new Pen(Settings.BorderColor, Settings.BorderWidth);
            PointF[] trianglePoints = {
                    triangle.Point1,
                    triangle.Point2,
                    triangle.Point3
                };
            Painter.DrawPolygon(penObj, trianglePoints);
            Brush brushObj = new SolidBrush(Settings.FillColor);
            Painter.FillPolygon(brushObj, trianglePoints);
        }
    }
}
