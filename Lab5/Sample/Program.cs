using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Sign { get; set; }

        public override bool Equals(object obj)
        {
            Point b = obj as Point;
            if (b.X == this.X && b.Y == this.Y) return true;
            return false;
        }
    }

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
            body.Add(new Point { X = 0, Y = 0, Sign = '*' });
            DX = 1;
            DY = 0;
            IsAlive = true;
        }

        void Move()
        {
            int x = body[0].X + DX;
            int y = body[0].Y + DY;

            if (x >= Console.WindowWidth) { x = 0; }
            if (x < 0) { x = Console.WindowWidth - 1; }
            if (y >= Console.WindowHeight) { y = 0; }
            if (y < 0) { y = Console.WindowHeight - 1; }

            Point newHeadPos = new Point { X = x, Y = y, Sign = '*' };

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
            Clear();
            Move();
            Console.ForegroundColor = HeadColor;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(p.Sign);
                Console.ForegroundColor = BodyColor;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        void Clear()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(p.Sign);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void ChangeDirection(ConsoleKeyInfo pressedButton)
        {
            switch (pressedButton.Key)
            {
                case ConsoleKey.UpArrow:
                    DX = 0;
                    DY = -1;
                    break;
                case ConsoleKey.DownArrow:
                    DX = 0;
                    DY = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    DX = -1;
                    DY = 0;
                    break;
                case ConsoleKey.RightArrow:
                    DX = 1;
                    DY = 0;
                    break;
                default:
                    break;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int WindowH = 30;
            int WindowW = 80;
            Console.SetWindowSize(WindowW, WindowH);
            Console.CursorVisible = false;
            ConsoleKeyInfo cki;
            Snake snake = new Snake();

            int speed = 250;
            do
            {
                while (Console.KeyAvailable == false)
                {
                    snake.Draw();
                    Thread.Sleep(speed);
                }

                cki = Console.ReadKey(true);
                snake.ChangeDirection(cki);
                    
            }
            while (snake.IsAlive);
        }
    }
}
