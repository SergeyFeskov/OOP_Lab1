using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab1
{
    public partial class Form1 : Form
    {
        private List<Figure> figures;
        private const int FigAm = 7;
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
            figures = new List<Figure>()
            {
                new Point(),
                new Line(25, (float)(Math.PI / 6)),
                new Triangle(new Line(40, (float)(Math.PI / 3)), new Line(70, 0)),
                new RectTriangle(50, 50, (float)(Math.PI / 2)),
                new RightTriangle(new Line(60, 0)),
                new Quadrangal(new PointF(0, 0), new Line(40, 1), new Line(65, (float)-0.1), new Line(30, -2)),
                new Ellipse(new PointF(0, 0), 40, 25, 0.6)
            };
        }


        private void button1_Click(object sender, EventArgs e)
        {
            currFigNum = 0;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
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
