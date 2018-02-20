using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Snake
    {
        ConsoleColor HeadColor = ConsoleColor.Black;
        public ConsoleColor BodyColor = ConsoleColor.Green;// { get; set; }
        public List<Point> body { get; set; }
        public int DX { get; set; }
        public int DY { get; set; }
        public bool IsAlive { get; set; }
        
        public Snake()
        {
            body = new List<Point>();
            BodyColor = new ConsoleColor();
            
            BodyColor = ConsoleColor.Green;
            body.Add(new Point { X = 39, Y = 10, Sign = '█' });
            DX = 1;
            DY = 0;
            IsAlive = true;
        }

        public void Move()
        {
            int x = body[0].X + DX;
            int y = body[0].Y + DY;
            /*
            if (x < 1) { x = 78; }
            if (x > 77) { x = 1; }
            if (y < 3) { x = 20; }
            if (y > 20) { x = 3; }
            */

            Point newHeadPos = new Point { X = body[0].X + DX, Y = body[0].Y + DY, Sign = '█' };

            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
                body[i].Sign = body[i - 1].Sign;
            }

            body[0] = newHeadPos;
        }

        public void Draw()
        {
            Console.ForegroundColor = HeadColor;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(p.Sign);
                //Console.WriteLine($"[{p.X}, {p.Y}]");
                Console.ForegroundColor = BodyColor;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void Clear()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(p.Sign);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
