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
        private const int FigAm = 1;
        private Graphics painter;
        private int currFigNum;
        private int figX;
        private int figY;

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
                new Point()
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
                figures[currFigNum].X = e.X;
                figures[currFigNum].Y = e.Y;
                figures[currFigNum].Draw(painter);
                currFigNum++;
            }
        }
    }
}
