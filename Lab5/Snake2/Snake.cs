using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Snake
    {
        public List<Point> body;
        public int dx { get; set; }
        public int dy { get; set; }

        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(5, 5, '*'));
            dx = 1;
            dy = 0;
        }

        public void Draw()
        {
            Clear();
            Move();

            Console.ForegroundColor = ConsoleColor.White;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(p.sign);
            }


        }

        void Clear()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Point p1 = body[body.Count - 1];
            Console.SetCursorPosition(p1.x, p1.y);
            Console.Write(' ');
        }

        public void Move()
        {
            int x = body[0].x + dx;
            int y = body[0].y + dy;
            Point newHeadPos = new Point(x, y, '*');

            if (x >= Console.WindowWidth) { x = 1; }
            if (x < 1) { x = Console.WindowWidth - 1; }
            if (y >= Console.WindowHeight) { y = 1; }
            if (y < 1) { y = Console.WindowHeight - 1; }


            for (int i = body.Count-1; i>0; i--)
            {
                body[i] = body[i - 1];
            }

            body[0] = newHeadPos;
        }

    }
}
