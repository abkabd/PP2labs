using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApplication
{
    enum Tools
    {
        Pen,
        Eraser,
        Fill,
        EyeDropper,
        Line,
        Rectangle,
        Ellipse,
        Triangle,
        Text
    }
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics gfx;
        Pen pen = new Pen(Color.Black);
        Pen eraserPen = new Pen(Color.White);
        Tools currentTool;
        Color selectedColor, initColor;

        Point prevPnt, curPnt;

        Queue<Point> q = new Queue<Point>();

        bool isPressed;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            gfx = Graphics.FromImage(bmp);
            pictureBox.Image = bmp;

            gfx.Clear(Color.White);
            gfx.SmoothingMode = SmoothingMode.HighQuality;

            currentTool = Tools.Pen;
            selectedColor = Color.Black;

            isPressed = false;
            pbox2.BackColor = Color.Black;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            prevPnt = e.Location;
            isPressed = true;
            switch (currentTool)
            {
                case Tools.Pen:
                    break;
                case Tools.Eraser:
                    break;
                case Tools.Fill:
                    int x = e.X;
                    int y = e.Y;
                    initColor = bmp.GetPixel(x, y);
                    q.Enqueue(new Point(x, y));
                    bmp.SetPixel(x, y, selectedColor);
                    while (q.Count != 0)
                    {
                        Point p = q.Dequeue();
                        Fill(p.X - 1, p.Y);
                        Fill(p.X + 1, p.Y);
                        Fill(p.X, p.Y - 1);
                        Fill(p.X, p.Y + 1);
                    }
                    break;
                case Tools.EyeDropper:
                    selectedColor = bmp.GetPixel(e.Location.X, e.Location.Y);
                    break;
                case Tools.Line:
                    break;
                case Tools.Rectangle:
                    break;
                case Tools.Ellipse:
                    break;
                case Tools.Triangle:
                    break;
                case Tools.Text:
                    break;
                default:
                    break;
            }
        }

        private void Fill(int x, int y)
        {
            if (x < 0 || x >= pictureBox.Width || y < 0 || y >= pictureBox.Height)
                return;

            if (bmp.GetPixel(x, y) == initColor)
            {
                bmp.SetPixel(x, y, selectedColor);
                q.Enqueue(new Point(x, y));
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                curPnt = e.Location;

                switch (currentTool)
                {
                    case Tools.Pen:
                        gfx.DrawLine(MyPen(), prevPnt, curPnt);
                        prevPnt = curPnt;
                        break;
                    case Tools.Eraser:
                        gfx.DrawLine(eraserPen, prevPnt, curPnt);
                        prevPnt = curPnt;
                        break;

                }
                pictureBox.Refresh();
            }
            

        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
            curPnt = e.Location;
            switch (currentTool)
            {
                case Tools.Pen:
                    break;
                case Tools.Eraser:
                    break;
                case Tools.Fill:
                    break;
                case Tools.EyeDropper:
                    ShowCurColor();

                    break;
                case Tools.Line:
                    gfx.DrawLine(MyPen(), prevPnt, curPnt);
                    break;
                case Tools.Rectangle:
                    gfx.DrawRectangle(MyPen(), GetRectangle());
                    break;
                case Tools.Ellipse:
                    gfx.DrawEllipse(MyPen(), GetRectangle());
                    break;
                case Tools.Triangle:
                    gfx.DrawPolygon(MyPen(), GetTriangle());
                    break;
                case Tools.Text:
                    break;
                default:
                    break;
            }
            pictureBox.Refresh();
        }

        private PointF[] GetTriangle()
        {
            PointF[] points =
            {
                new PointF((prevPnt.X + curPnt.X)/2, prevPnt.Y),
                new PointF(prevPnt.X, curPnt.Y),
                new PointF(curPnt.X, curPnt.Y)
            };

            return points;
        }

        private Rectangle GetRectangle()
        {
            Rectangle rect;
            int x = Math.Min(prevPnt.X, curPnt.X);
            int y = Math.Min(prevPnt.Y, curPnt.Y);
            int w = Math.Abs(prevPnt.X - curPnt.X);
            int h = Math.Abs(prevPnt.Y - curPnt.Y);
            rect = new Rectangle(x, y, w, h);
            return rect;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Pen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Rectangle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Line;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Eraser;
            eraserPen.Width = trackBar1.Value + 10;
            eraserPen.StartCap = LineCap.Round;
            eraserPen.EndCap = LineCap.Round;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Triangle;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTool = Tools.EyeDropper;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Fill;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Ellipse;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            ShowCurColor();
        }
        private void ShowCurColor()
        {
            pbox2.BackColor = selectedColor;
        }
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (isPressed)
            {
                switch (currentTool)
                {
                    case Tools.Pen:
                        break;
                    case Tools.Eraser:
                        break;
                    case Tools.Fill:
                        break;
                    case Tools.EyeDropper:
                        break;
                    case Tools.Line:
                        e.Graphics.DrawLine(MyPen(), prevPnt, curPnt);
                        break;
                    case Tools.Rectangle:
                        e.Graphics.DrawRectangle(MyPen(), GetRectangle());
                        break;
                    case Tools.Ellipse:
                        e.Graphics.DrawEllipse(MyPen(), GetRectangle());
                        break;
                    case Tools.Triangle:
                        e.Graphics.DrawPolygon(MyPen(), GetTriangle());
                        break;
                    case Tools.Text:
                        break;
                    default:
                        break;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (currentTool == Tools.Pen)
            {
                pen.Width = trackBar1.Value;
            }
            if (currentTool == Tools.Eraser)
            {
                eraserPen.Width = trackBar1.Value + 10;
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            selectedColor = btn.BackColor;
            ShowCurColor();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Choose file ...";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(Bitmap.FromFile(openFileDialog1.FileName));
                gfx = Graphics.FromImage(bmp);
                pictureBox.Image = bmp;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save paint as ...";
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.Filter =
                "JPEG File(*.jpg)|*.jpg|" +
                "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "TIF File(*.tif)|*.tif|" +
                "PNG File(*.png)|*.png";
            saveFileDialog1.ShowHelp = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                string fileExtn = fileName.Remove(0, fileName.Length - 3);

                switch (fileExtn)
                {
                    case "bmp":
                        pictureBox.Image.Save(fileName, ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName, ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            selectedColor = colorDialog1.Color;
            ShowCurColor();

        }
        
        private Pen MyPen()
        {
            
            pen = new Pen(selectedColor, trackBar1.Value);
            pen.EndCap = LineCap.Round;
            pen.StartCap = LineCap.Round;
            return pen;
        }
    }
}
