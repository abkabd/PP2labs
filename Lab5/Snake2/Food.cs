using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Food
    {
        public Point body { get; set; }

        public Food()
        {
            body = new Point(6, 12, '$');
        }

        public Point Generate()
        {
            Random rd = new Random();
            int x = rd.Next(1, 78);
            int y = rd.Next(3, 20);
            return new Point(x, y, body.sign);
        }

        public void Draw()
        {
            Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(body.x, body.y);
            Console.Write(body.sign);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }

        public void Clear()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(body.x, body.y);
            Console.Write(body.sign);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
