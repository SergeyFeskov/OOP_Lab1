using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2.Drawers
{
    public class DrawerSettings
    {
        public DrawerSettings(int BorderWidth, Color BorderColor, Color FillColor)
        {
            this.BorderWidth = BorderWidth;
            this.BorderColor = BorderColor;
            this.FillColor = FillColor;
        }

        public int BorderWidth;
        public Color BorderColor;
        public Color FillColor;
    }
}
