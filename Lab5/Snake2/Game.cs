using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    class Game
    {
        Snake snake;
        Food food;

        public Game()
        {
            snake = new Snake();
            food = new Food();
        }

        public void Start()
        {
            Draw();
            do
            {
                ConsoleKeyInfo cki = Console.ReadKey();
                while (Console.KeyAvailable == false)
                {
                    Draw();
                    Thread.Sleep(300);
                }

                switch(cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        snake.dy = -1;
                        snake.dx = 0;
                        break;
                    case ConsoleKey.DownArrow:
                        snake.dy = 1;
                        snake.dx = 0;
                        break;
                    case ConsoleKey.LeftArrow:
                        snake.dx = -1;
                        snake.dy = 0;
                        break;
                    case ConsoleKey.RightArrow:
                        snake.dx = 1;
                        snake.dy = 0;
                        break;
                }
            }
            while (true);
        }

        public void Draw()
        {
            if(snake.body[0].Equals(food.body))
            {
                Point p = snake.body[snake.body.Count - 1];
                snake.body.Add(new Point(p.x - 1, p.y, '*'));
                food.body = food.Generate();
            }
            snake.Draw();
            food.Draw();
        }
        
    }
}
