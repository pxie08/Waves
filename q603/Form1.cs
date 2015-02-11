using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace q603
{
    public partial class Form1 : Form
    {
        private Bitmap myCanvas;
        private int width;
        private int height;
        List<Cell> cellList = new List<Cell>();
        Pen myPen = new Pen(Color.Black);
        bool increase = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            width = 400;
            height = 400;
            myCanvas = new Bitmap(width, height,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(myCanvas);
            g.Clear(Color.LightGray);

            timer1.Interval = trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(myCanvas);
            if (increase)
            {
                foreach (Cell c in cellList)
                {
                    c.draw(g, Color.Black);
                    c.update(10, 5, 5);
                }
            }
            if (!increase)
            {
                foreach (Cell c in cellList)
                {
                    c.draw(g, Color.LightGray);
                    c.update(-10, -5, -5);
                    if (c.getWidth() <= 0)
                    {
                        timer1.Stop();
                        increase = true;
                        startstopButton.Text = "Start";
                        tofroButton.Text = "Increase";
                    }
                }
            }
            this.Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(myCanvas);
            if (!timer1.Enabled)
            {
                cellList.Add(new Cell(new Point(e.X - 5, e.Y - 5), 10, 10));
                g.DrawEllipse(myPen, e.X - 5, e.Y - 5, 10, 10);
                this.Refresh();
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(myCanvas, 0, 0, myCanvas.Width, myCanvas.Height);
        }


        private void startstopButton_Click(object sender, EventArgs e)
        {
            if (startstopButton.Text == "Start")
            {
                timer1.Start();
                startstopButton.Text = "Stop";
            }
            else if (startstopButton.Text == "Stop")
            {
                timer1.Stop();
                startstopButton.Text = "Start";
            }
        }

        private void tofroButton_Click(object sender, EventArgs e)
        {
            if (tofroButton.Text == "Increase")
            {
                increase = false;
                tofroButton.Text = "Decrease";
            }
            else if (tofroButton.Text == "Decrease")
            {
                increase = true;
                tofroButton.Text = "Increase";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            increase = true;
            startstopButton.Text = "Start";
            tofroButton.Text = "Increase";
            cellList.Clear();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            intervalLabel.Text = trackBar1.Value.ToString();
            timer1.Interval = trackBar1.Value;
        }

    }

    public class Cell
    {
        private int width;
        private int height;
        private Point location;

        public Cell()
        {
            location = new Point(0, 0);
            width = 0;
            height = 0;
        }

        public Cell(Point p, int w, int h)
        {
            location = p;
            width = w;
            height = h;
        }

        public void update(int r, int x, int y)
        {
            width += r;
            height += r;
            location.X -= x;
            location.Y -= y;
        }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }

        public Point getLocation()
        {
            return location;
        }

        public void draw(Graphics g, Color newColor)
        {
            g.DrawEllipse(new Pen(newColor), location.X, location.Y, width, height);
        }

    }

}