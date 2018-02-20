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
    
    public class Game
    {
        Snake snake = new Snake();
        Wall wall = new Wall();
        Food food = new Food();
        int currentLevel { get; set; }

        /*
        public void Start()
        {
            Console.Clear();
            ConsoleKeyInfo cki;
            while (true)
            {
                snake.Draw();
                cki = Console.ReadKey();
                ChangeDirection(cki);
                snake.Move();
            }
            Console.ReadKey();
        }
        */
        ////-----------------------------------------------------------//
        public void Start()
        {
            Initialize();
            wall.Draw();

            ConsoleKeyInfo cki;
            int speed = 100;
            do
            {
                while (Console.KeyAvailable == false)
                {
                    snake.Clear();
                    food.Draw();
                    snake.Draw();
                    snake.Move();
                    Thread.Sleep(speed);
                }

                cki = Console.ReadKey(true);
                ChangeDirection(cki);
            }
            while (snake.IsAlive);
            Console.WriteLine("Game Over!");
            //int dx = snake.DX, dy = snake.DY, speed = 250, addSpeed = 10, speedMax = 10, speedMin = 300;
            /*
            do
            {
                while (Console.KeyAvailable == false)
                {
                    snake.Move();

                    /*
                    Console.SetCursorPosition(x, y);    
                    Console.Write("█");

                    prevx = x;
                    prevy = y;
                    x += snake.DX;
                    y += snake.DY;
                    */

            //Thread.Sleep(speed);
            /*
            Console.SetCursorPosition(prevx, prevy);
            Console.Write(" ");
            *
        }

        cki = Console.ReadKey(true);
        ChangeDirection(cki);
        /*
        switch (cki.Key)
        {
            case ConsoleKey.Add:
                {
                    speed -= addSpeed;
                    if (speed < speedMax)
                    {
                        speed = speedMax;
                    }
                    break;
                }
            case ConsoleKey.Subtract:
                {
                    speed += addSpeed;
                    if (speed > speedMin)
                    {
                        speed = speedMin;
                    }
                    break;
                }

            default:
                {
                    break;
                }

        }

    } while (true);
    */
        }

        public void Initialize()
        {
            Console.Clear();
            currentLevel = 2;
            wall.LoadLevel(currentLevel);
            //DrawBorder();

        }

        public void ChangeDirection(ConsoleKeyInfo pressedButton)
        {
            switch (pressedButton.Key)
            {
                case ConsoleKey.UpArrow:
                    snake.DX = 0;
                    snake.DY = -1;
                    break;
                case ConsoleKey.DownArrow:
                    snake.DX = 0;
                    snake.DY = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    snake.DX = -1;
                    snake.DY = 0;
                    break;
                case ConsoleKey.RightArrow:
                    snake.DX = 1;
                    snake.DY = 0;
                    break;
                default:
                    break;
            }
        }

        //void DrawBorder()
        //{
        //    Console.SetCursorPosition(0, 0);
        //    FileStream fs = new FileStream(@"files\Border.txt", FileMode.Open, FileAccess.Read);
        //    StreamReader sr = new StreamReader(fs);

        //    string value = sr.ReadToEnd();
        //    Console.WriteLine(value);

        //    sr.Close();
        //    fs.Close();
        //}

        ////-----------------------------------------------------------//

    }
}
