using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * GENERAL CODE INFORMATION:
 * all degrees are calculated from X asix counter-clockwise 
 * protected constructors exist in code for constructors inheritance
 * Point1 set code exists for recalculation of figure's cords (if point1 is changed) so, that figure's form stays same
 */

namespace OOP_Lab1
{
    public partial class Form1 : Form
    {
        private List<Figure> figures;
        private const int FigAm = 8;
        private Graphics painter;
        private int currFigNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            painter = pictureBox1.CreateGraphics();
            currFigNum = FigAm;

            // static init of figures list
            figures = new List<Figure>()
            {
                new Point(new PointF(0,0)),
                new Line(new PointF(0,0), 25, (float)(Math.PI / 6)),
                new Triangle(new PointF(0,0), new Vector(40, Math.PI / 3), new Vector(70, 0)),
                new RectTriangle(new PointF(0,0), new Vector(85, 0.4), 100),
                new RightTriangle(new PointF(0,0), new Vector(60, Math.PI / 3)),
                new Quadrangal(new PointF(0,0), new Vector(40, (double)1), new Vector(65, (double)-0.1), new Vector(30, (double)-2)),
                new Ellipse(new PointF(0,0), 40, 25),
                new Circle(new PointF(0,0), 55)
            };
        }


        private void button1_Click(object sender, EventArgs e)
        {
            currFigNum = 0;
            painter.Clear(Color.White);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // if not all figures are drawn, gets click cords and draws figure 
            if (currFigNum != FigAm)
            {
                PointF ClickCords = new PointF(e.X, e.Y);
                figures[currFigNum].Point1 = ClickCords;
                figures[currFigNum].Draw(painter);
                currFigNum++;
            }
        }
    }
}
