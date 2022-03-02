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
        private const int FigAm = 4;
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
                new RightTriangle(50, 50, (float)(Math.PI / 2))
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
                figures[currFigNum].StartPoint = ClickCords;
                figures[currFigNum].Draw(painter);
                currFigNum++;
            }
        }
    }
}
