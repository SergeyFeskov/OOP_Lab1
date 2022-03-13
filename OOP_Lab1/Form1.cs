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
        private readonly Drawers.DrawerSettings baseSettings = new Drawers.DrawerSettings(2, Color.SandyBrown, Color.LightYellow);
        private enum FigureName
        {
            Point,
            Line,
            Triangle,
            RectTriangle,
            RightTriangle,
            Qudrangal,
            Ellipse,
            Circle
        }

        private Graphics painter;               
        private bool buttonClicked = false;
        private int clicksCount;
        private int clicksAm;
        private FigureName currFigName;
        private Figure figure;

        private List<PointF> clicks;
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
            switch (currFigName)
            {
                case FigureName.RectTriangle:
                    float legSize;
                    if (float.TryParse(legTextBox.Text, out legSize))
                    {                        
                        figure = new RectTriangle(clicks[0], new Vector(clicks[1].X - clicks[0].X, clicks[0].Y - clicks[1].Y), legSize);
                    }
                    else
                    {
                        MessageBox.Show("High leg size value is invalid.");
                    }
                    break;

                case FigureName.Line:
                    figure = new Line(clicks[0], clicks[1]);
                    break;

                case FigureName.Triangle:
                    figure = new Triangle(clicks[0], clicks[1], clicks[2]);
                    break;

                case FigureName.RightTriangle:
                    figure = new RightTriangle(clicks[0], new Vector(clicks[1].X - clicks[0].X, clicks[0].Y - clicks[1].Y));
                    break;

                case FigureName.Qudrangal:
                    figure = new Quadrangal(clicks[0], clicks[1], clicks[2], clicks[3]);
                    break;

                case FigureName.Ellipse:
                    float radX;
                    float radY;
                    if (float.TryParse(RadXTextBox.Text, out radX) && float.TryParse(RadYTextBox.Text, out radY))
                    {
                        figure = new Ellipse(clicks[0], radX, radY);
                    }
                    else
                    {
                        MessageBox.Show("Horizontal or/and vertical radius is/are invalid.");
                    }
                    break;

                case FigureName.Circle:
                    figure = new Circle(clicks[0], Math.Sqrt((clicks[1].X - clicks[0].X) * (clicks[1].X - clicks[0].X) + (clicks[1].Y - clicks[0].Y) * (clicks[1].Y - clicks[0].Y)));
                    break;

                default:
                    MessageBox.Show("Code error.");
                    return;           
            }
            clicks = null;
            
            bool figureDrawn = false;
            foreach (Drawers.Drawer drawer in drawers)
            {
                if (drawer.Handles(figure))
                {
                    drawer.Draw(figure);
                    figureDrawn = true;            
                    break;
                }
            }
            if (!figureDrawn)
            {
                MessageBox.Show("Drawing of this figure is not implemented yet.");
            }
            figure = null;
        }

        private void initFigureDrawing(FigureName figureName, int figureClicks)
        {
            currFigName = figureName;
            clicksAm = figureClicks;

            buttonClicked = true;
            clicksCount = 0;
            clicks = new List<PointF>(clicksAm);
        }

        private void rectTriangleButton_Click(object sender, EventArgs e)
        {
            initFigureDrawing(FigureName.RectTriangle, 2);
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            initFigureDrawing(FigureName.Line, 2);
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            initFigureDrawing(FigureName.Triangle, 3);
        }

        private void rightTriangleButton_Click(object sender, EventArgs e)
        {
            initFigureDrawing(FigureName.RightTriangle, 2);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            painter.Clear(Color.White);
        }

        private void quadrangalButton_Click(object sender, EventArgs e)
        {
            initFigureDrawing(FigureName.Qudrangal, 4);
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            initFigureDrawing(FigureName.Ellipse, 1);
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            initFigureDrawing(FigureName.Circle, 2);
        }
    }
}
