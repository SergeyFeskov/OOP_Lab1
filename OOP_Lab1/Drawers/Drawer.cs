using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab2.Drawers
{
    public abstract class Drawer
    {
        public Drawer(Graphics painter, DrawerSettings drawerSettings)
        {
            Painter = painter;
            Settings = drawerSettings;
        }

        public abstract void Draw(Figure figure);
        public abstract bool Handles(Figure figure);

        public Graphics Painter { get; private set;  }
        public DrawerSettings Settings { get; private set; }
    }
}
