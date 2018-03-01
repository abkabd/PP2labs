using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeGame
{
    
    public class Snake
    {
        ConsoleColor HeadColor = ConsoleColor.Black;
        public ConsoleColor BodyColor = ConsoleColor.Green;// { get; set; }

        public List<Point> body { get; set; }
        public int DX { get; set; }
        public int DY { get; set; }
        public bool IsAlive { get; set; }
        [XmlIgnore]
        public int speed { get; set; }
        int coeff;
        int BorderH = 24, BorderW = 78;
        public Snake()
        {
            body = new List<Point>();
            BodyColor = new ConsoleColor();
            speed = StandartSettings.Speed;
            BodyColor = StandartSettings.snakeColor;
            body.Add(new Point { X = 35, Y = 10, Sign = '█' });
            DX = 0;
            DY = 1;
            IsAlive = true;
            coeff = 3 * speed / 8;
        }

        public Snake(int k)
        {
            body = new List<Point>();
            BodyColor = new ConsoleColor();
            speed = StandartSettings.Speed;
            BodyColor = ConsoleColor.Green;
            IsAlive = true;
            coeff = 3 * speed / 8;
        }

        public void ChangeDirection(ConsoleKeyInfo pressedButton)
        {
            switch (pressedButton.Key)
            {
                case ConsoleKey.UpArrow:
                    if(DX == 0 && DY == 1)
                    {
                        break;
                    }

                    if(DX == 0 && DY == -1)
                    {
                        break;
                    }

                    DX = 0;
                    DY = -1;
                    speed += coeff;
                    break;
                case ConsoleKey.DownArrow:
                    if (DX == 0 && DY == -1)
                    {
                        break;
                    }

                    if(DX == 0 && DY == 1)
                    {
                        break;
                    }

                    DX = 0;
                    DY = 1;
                    speed += coeff;
                    break;
                case ConsoleKey.LeftArrow:
                    if (DX == 1 && DY == 0)
                    {
                        break;
                    }

                    if(DX == -1 && DY == 0)
                    {
                        break;
                    }
                    DX = -1;
                    DY = 0;
                    speed -= coeff;
                    break;
                case ConsoleKey.RightArrow:
                    if (DX == -1 && DY == 0)
                    {
                        break;
                    }

                    if(DX == 1 && DY == 0)
                    {
                        break;
                    }
                    DX = 1;
                    DY = 0;
                    speed -= coeff;
                    break;

                default:
                    break;
            }
        }

        public void Draw()
        {
            Clear();

            Move();
            
            /*

            Console.ForegroundColor = HeadColor;
            
            Point p = body[0];
            Console.SetCursorPosition(p.X, p.Y);
            Console.Write(p.Sign);

            Console.ForegroundColor = ConsoleColor.Yellow;

            */
            Console.ForegroundColor = HeadColor;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(p.Sign);
                Console.ForegroundColor = BodyColor;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            
        }

        void Move()
        {
            int x = body[0].X + DX;
            int y = body[0].Y + DY;

            if (x >= BorderW) { x = 1; }
            if (x < 1) { x = BorderW - 1; }
            if (y >= BorderH) { y = 3; }
            if (y < 3) { y = BorderH - 1; }

            Point newHeadPos = new Point { X = x, Y = y, Sign = body[0].Sign };

            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
                body[i].Sign = body[i - 1].Sign;
            }

            body[0] = newHeadPos;
        }
        
        public void Clear()
        {
            Console.ForegroundColor = BodyColor;
            Point p = body[0];
            Console.SetCursorPosition(p.X, p.Y);
            Console.Write(p.Sign);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            p = body[body.Count - 1];
            Console.SetCursorPosition(p.X, p.Y);
            Console.Write(p.Sign);

            

            Console.ForegroundColor = ConsoleColor.Yellow;
            /*
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(p.Sign);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            */
        }

        public void Clear2()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(p.Sign);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void Save()
        {
            StreamWriter sw = new StreamWriter(@"Serialization\snake.xml", false);
            XmlSerializer xs = new XmlSerializer(typeof(Snake));
            xs.Serialize(sw, this);

            sw.Close();
        }

        public Snake Load()
        {
            Snake x;
            FileStream fs = new FileStream(@"Serialization\snake.xml", FileMode.Open, FileAccess.Read);

            XmlSerializer xs = new XmlSerializer(typeof(Snake));
            x = xs.Deserialize(fs) as Snake;
            fs.Close();
            return x;
        }

    }
}
