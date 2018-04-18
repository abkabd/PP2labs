using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsProject
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        Pen pen;

        Color BackgroundColor;
        Color StarsColor;
        Color AsteroidsColor;
        Color SpaceshipColor;
        Color GunColor;

        int starSize;
        int asteroidSize;
        int spaceshipSize;
        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
            DefaultSettings();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawPicture();
        }

        private void DefaultSettings()
        {
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            BackgroundColor = Color.Blue;
            StarsColor = Color.White;
            AsteroidsColor = Color.Red;
            SpaceshipColor = Color.Yellow;
            GunColor = Color.Green;

            starSize = 35;
            asteroidSize = 60;
            spaceshipSize = 120;
        }

        private void DrawPicture()
        {
            SetBackground();
            DrawSpaceship();
            DrawGun();
            DrawBullet();
            DrawStars();
            DrawAsteroids();
            DrawInfo();
        }

        private void DrawInfo()
        {
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            string text = "Level: 1";
            Rectangle rect = new Rectangle(600, 50, 150, 30);
            gfx.FillRectangle(new SolidBrush(Color.GreenYellow), rect);
            gfx.DrawRectangle(new Pen(Color.Yellow, 4), rect);
            gfx.DrawString(text, new Font("Times New Roman", 12), new SolidBrush(Color.Black), rect, sf);
        }

        private void DrawAsteroids()
        {
            DrawAsteroid(new Point(150, 150));
            DrawAsteroid(new Point(610, 140));
            DrawAsteroid(new Point(200, 290));
            DrawAsteroid(new Point(520, 350));
        }

        private void DrawAsteroid(Point p)
        {
            Point p2 = new Point(p.X + asteroidSize + asteroidSize/4, p.Y + asteroidSize);
            gfx.FillPolygon(new SolidBrush(AsteroidsColor), GetTriangle(p, p2));
            gfx.FillPolygon(new SolidBrush(AsteroidsColor), GetInverseTriangle(p2, p));

        }

        private Point[] GetTriangle(Point p1, Point p2)
        {
            Point[] points = {
                                new Point(p1.X, p2.Y),
                                new Point((p1.X + p2.X)/2, p1.Y),
                                p2};
            return points;
        }

        private Point[] GetInverseTriangle(Point p1, Point p2)
        {
            int sm = asteroidSize / 3;
            Point[] points = {
                                new Point(p1.X, p2.Y + sm),
                                new Point((p1.X + p2.X)/2, p1.Y + sm),
                                new Point(p2.X, p2.Y + sm)};
            return points;
        }

        private void DrawSpaceship()
        {
            gfx.FillPolygon(new SolidBrush(SpaceshipColor), GetSpaceship(new PointF(420, 250)));
        }

        private PointF[] GetSpaceship(PointF p)
        {
            int n = 6;
            PointF[] points = new PointF[n];
            float deg = 360 / n;
            for (int i = 0; i < n; i++)
            {
                points[i] = new PointF(
                    p.X + spaceshipSize/2 * (float)Math.Cos(i * deg * Math.PI / 180f),
                    p.Y + spaceshipSize/2 * (float)Math.Sin(i * deg * Math.PI / 180f));
            }
            return points;
        }

        private PointF[] GetHypotrochoid(Point p, int A, int B, int C)
        {
            
            int iter = 100;

            int cx = p.X;
            int cy = p.Y;
            double t = 0;
            double dt = Math.PI / iter;
            double max_t = 2 * Math.PI * B / GCD(A, B);
            double x1 = cx + X(t, A, B, C);
            double y1 = cy + Y(t, A, B, C);

            List<PointF> points = new List<PointF>();
            points.Add(new PointF((float)x1, (float)y1));
            while (t <= max_t)
            {
                t += dt;
                x1 = cx + X(t, A, B, C);
                y1 = cy + Y(t, A, B, C);
                points.Add(new PointF((float)x1, (float)y1));
            }

            
            return points.ToArray();
        }

        private double X(double t, double A, double B, double C)
        {
            return (A - B) * Math.Cos(t) + C * Math.Cos((A - B) / B * t);
        }
        
        private double Y(double t, double A, double B, double C)
        {
            return (A - B) * Math.Sin(t) - C * Math.Sin((A - B) / B * t);
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        private void DrawGun()
        {
            Brush brush = new SolidBrush(GunColor);
            Point p = new Point(405, 240);
            Point p1 = new Point(390, 210);
            Point p2 = new Point(450, 240);
            gfx.DrawRectangle(new Pen(GunColor, 2f), new Rectangle(p, new Size(30, 50)));
            gfx.FillRectangle(brush, new Rectangle(p, new Size(30, 50)));
            gfx.FillPolygon(brush, GetTriangle(p1, p2));
        }
        

        private void DrawBullet()
        {

            Brush brush = new SolidBrush(GunColor);
            Pen myPen = new Pen(Color.Red, 2f);
            int k = 3;
            gfx.FillPolygon(brush, GetHypotrochoid(new Point(420, 150), 5 * k, 3 * k, 5 * k));
        }

        private void DrawStars()
        {
            DrawStar(new Point(50, 90));
            DrawStar(new Point(300, 70));
            DrawStar(new Point(500, 110));
            DrawStar(new Point(700, 200));
            DrawStar(new Point(60, 400));
            DrawStar(new Point(320, 350));
            DrawStar(new Point(650, 300));
            DrawStar(new Point(690, 410));

        }

        private void DrawStar(Point p)
        {
            gfx.FillEllipse(new SolidBrush(StarsColor), new Rectangle(p, new Size(starSize, starSize)));
        }

        private void SetBackground()
        {
            gfx.FillRectangle(new SolidBrush(BackgroundColor), 25, 25, 750, 430);
            pen = new Pen(Color.Black, 15);
            gfx.DrawRectangle(pen, 25, 25, 750, 430);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }
    }
}
