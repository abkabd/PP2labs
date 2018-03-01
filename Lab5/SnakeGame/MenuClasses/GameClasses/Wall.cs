using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SnakeGame
{
    public class Wall
    {
        ConsoleColor wallColor = ConsoleColor.White;
        public List<Point> body { get; set; }
        

        public void LoadLevel(int levelCount)
        {
            this.body = new List<Point>();
            string fname = @"Levels\Level" + levelCount + ".txt";

            FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            int y = 3;

            while ((line = sr.ReadLine()) != null)
            {
                for (int x = 0; x < line.Length; ++x)
                {
                    if (line[x] == '#')
                    {
                        this.body.Add(new Point { X = x + 1, Y = y, Sign = '#'});
                    }
                }
                y++;
            }

            sr.Close();
            fs.Close();
        }


        public void Draw()
        {
            Console.ForegroundColor = wallColor;
            for (int i = 0; i < body.Count; i++)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write(body[i].Sign);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

        }

        public void Clear()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < body.Count; i++)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write(body[i].Sign);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

        }
    }
}