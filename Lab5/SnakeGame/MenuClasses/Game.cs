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
        int score = 0;
        
        public void Start()
        {
            Initialize();
            ConsoleKeyInfo cki;
            do
            {
                while (Console.KeyAvailable == false)
                {
                    Draw();
                    Thread.Sleep(snake.speed);
                }
                
                cki = Console.ReadKey(true);
                snake.ChangeDirection(cki);

            }
            while (snake.IsAlive);
        }

        void Initialize()
        {
            Console.Clear();
            DrawBorder();
            food.Draw();
        }

        void StatusBar()
        {

            Console.SetCursorPosition(5, 1);
            Console.Write("Score:");
            Console.SetCursorPosition(15, 1);
            Console.Write(score);

            Console.SetCursorPosition(30, 1);
            Console.Write("Speed:");
            Console.SetCursorPosition(40, 1);
            Console.Write(snake.speed);
            Console.Write("  ");
        }

        void Draw()
        {
            snake.Draw();
            StatusBar();
            if (snake.body[0].Equals(food.body))
            {
                snake.body.Add(food.body);
                food.body = food.Generate();
                food.Draw();
                score++;
            }

        }
        void DrawBorder()
        {
            Console.SetCursorPosition(0, 0);
            FileStream fs = new FileStream(@"files\Border.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string value = sr.ReadToEnd();
            Console.WriteLine(value);

            sr.Close();
            fs.Close();
        }

    }
}
