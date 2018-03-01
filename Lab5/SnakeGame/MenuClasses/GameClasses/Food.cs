using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Food
    {
        public Point body { get; set; }

        public Food()
        {
            body = new Point { X = 6, Y = 12, Sign = '$' };
        }

        public Point Generate()
        {
            Random rd = new Random();
            int x = rd.Next(1, 78);
            int y = rd.Next(3, 20);
            return new Point { X = x, Y = y, Sign = body.Sign };
        }

        public void Draw()
        {
            Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(body.X, body.Y);
            Console.Write(body.Sign);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }

        public void Clear()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(body.X, body.Y);
            Console.Write(body.Sign);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
