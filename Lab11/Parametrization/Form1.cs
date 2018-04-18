using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parametrization
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics gfx;
        Pen pen = new Pen(Color.Black, 1f);
        Brush brush = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        }

        private PointF[] GetTrochoid(Point p)
        {
            int A = 30, B = 20;
            int angle = 50;
            int cx = p.X;
            int cy = p.Y;
            double t = 0;
            double dt = Math.PI/angle;
            double max_t = 2000;
            double x1 = cx + X(t, A, B);
            double y1 = cy + Y(t, A, B);
            List<PointF> points = new List<PointF>();
            while(t <= max_t)
            {
                t += dt;
                x1 = cx + X(t, A, B);
                y1 = cy + Y(t, A, B);
                points.Add(new PointF((float)x1, (float)y1));
            }
            return points.ToArray();
        }

        private double X(double t, double A, double B)
        {
            return A * t - B * Math.Sin(t);
        }

        private double Y(double t, double A, double B)
        {
            return A - B * Math.Cos(t);
        }

        
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            gfx.DrawPolygon(pen, GetTrochoid(new Point(10, 100)));
            pictureBox1.Refresh();
        }
    }
}
