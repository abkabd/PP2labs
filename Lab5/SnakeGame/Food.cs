using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Food
    {
        public Point body { get; set; }

        public Food()
        {
            body = new Point { X = 10, Y = 10, Sign = '$' };
        }

        public void Generate()
        {
            Random rd = new Random();
            int x = rd.Next(1, 78);
            int y = rd.Next(1, 20);
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(body.X + 1, body.Y + 3);
            Console.Write(body.Sign);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
