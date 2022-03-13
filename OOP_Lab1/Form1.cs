using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab2
{
    public partial class Form1 : Form
    {
        private Graphics painter;
        private int currFigInd;
        private readonly Drawers.DrawerSettings baseSettings = new Drawers.DrawerSettings(2, Color.SandyBrown, Color.LightYellow);
        private bool buttonClicked = false;
        private int clicksCount;
        private int clicksAm;
        private List<PointF> clicks;

        private List<Figure> figures = new List<Figure>()
        {
            new Point(new PointF(0,0)),
            new Line(new PointF(0,0), 75, (float) (Math.PI / 6)),
            new Triangle(new PointF(0,0), new Vector(40, Math.PI / 3), new Vector(70, 0)),
            new RectTriangle(new PointF(0,0), new Vector(85, 0.4), 100),
            new RightTriangle(new PointF(0,0), new Vector(60, Math.PI / 3)),
            new Quadrangal(new PointF(0,0), new Vector(40, (double)1), new Vector(65, (double)-0.1), new Vector(30, (double)-2)),
            new Ellipse(new PointF(0,0), 40, 25),
            new Circle(new PointF(0,0), 55)
        };

        private List<Drawers.Drawer> drawers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            painter = pictureBox1.CreateGraphics();

            drawers = new List<Drawers.Drawer>()
            {
                new Drawers.PointDrawer(painter, baseSettings),
                new Drawers.LineDrawer(painter, baseSettings),
                new Drawers.TriangleDrawer(painter, baseSettings),
                new Drawers.QuadrangalDrawer(painter, baseSettings),
                new Drawers.EllipseDrawer(painter, baseSettings),
            };
            currFigInd = figures.Count;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            currFigInd = 0;
            painter.Clear(Color.White);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {            
            if (buttonClicked)
            {
                clicks.Add(new PointF(e.X, e.Y));
                clicksCount++;
                if (clicksCount == clicksAm)
                {
                    startPaint();
                }
            }
        }

        private void startPaint()
        {
            buttonClicked = false;
            switch (currFigInd)
            {
                case 3:
                    float legSize;
                    if (float.TryParse(legTextBox.Text, out legSize))
                    {                        
                        figures[currFigInd] = new RectTriangle(clicks[0], new Vector(clicks[1].X - clicks[0].X, clicks[0].Y - clicks[1].Y), legSize);
                    }
                    else
                    {
                        MessageBox.Show("High leg size value is invalid.");
                    }
                    break;

                default:
                    MessageBox.Show("Code error.");
                    return;           
            }
            
            bool figureDrawn = false;
            foreach (Drawers.Drawer drawer in drawers)
            {
                if (drawer.Handles(figures[currFigInd]))
                {
                    drawer.Draw(figures[currFigInd]);
                    figureDrawn = true;
                    currFigInd++;
                    break;
                }
            }
            if (!figureDrawn)
            {
                MessageBox.Show("Drawing of this figure is not implemented yet.");
            }           
        }

        private void rectTriangleButton_Click(object sender, EventArgs e)
        {
            currFigInd = 3;
            clicksAm = 2;

            buttonClicked = true;
            clicksCount = 0;
            clicks = new List<PointF>(clicksAm);
        }
    }
}
