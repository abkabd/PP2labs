using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeGame
{
    public class Game
    {
        Snake snake;
        Wall wall;
        Food food;
        int currentLevel { get; set; }
        int score;
        int ShowSpeed;
        bool esc = false;

        public Game()
        {
            snake = new Snake();
            wall = new Wall();
            food = new Food();
            currentLevel = 0;
            score = 0;
        }

        public Game(Snake _snake)
        {
            snake = _snake;
            snake.IsAlive = true;
            wall = new Wall();
            food = new Food();
            currentLevel = LoadObj("currentLevel");
            score = LoadObj("score");
        }

        public void Start()
        {
            Initialize();
            ConsoleKeyInfo cki;
            do
            {

                cki = Console.ReadKey(true);
                Process(cki);

                while (Console.KeyAvailable == false && snake.IsAlive && !esc)
                {
                    Draw();
                    Thread.Sleep(snake.speed);
                }
            }
            while (snake.IsAlive && !esc);

            if (esc)
            {
                Save();
            }
            if(!snake.IsAlive)
            {
                GameOver();
            }

        }

        void Initialize()
        {
            Console.Clear();
            DrawBorder();
            StatusBar();
            ShowSpeed = 11 - snake.speed / 20;
            wall.LoadLevel(currentLevel);
            wall.Draw();
            food.Draw();
            snake.Draw();
            //Draw();
        }

        void Process(ConsoleKeyInfo cki)
        {
            if(cki.Modifiers == ConsoleModifiers.Control)
            {
                switch (cki.Key)
                {
                    case ConsoleKey.P:
                        if (cki.Modifiers != ConsoleModifiers.Control)
                        {
                            break;
                        }
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.SetCursorPosition(33, 27);
                        Console.Write("Game paused!");
                        Console.ReadKey();
                        Console.SetCursorPosition(33, 27);
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write("              ");
                        break;
                    case ConsoleKey.S:
                        esc = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                snake.ChangeDirection(cki);
            }
            
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
            Console.Write(ShowSpeed + " / 10");
        }

        void Draw()
        {
            if (snake.body[0].Equals(food.body))
            {
                Sound();
                snake.body.Add(food.body);
                bool ok = false;
                while (!ok)
                {
                    bool ok1 = false;
                    Point f = food.Generate();
                    foreach (Point p1 in snake.body)
                    {
                        if (f.Equals(p1))
                        {
                            ok1 = false;
                            break;
                        }
                        ok1 = true;
                        foreach (Point p2 in wall.body)
                        {
                            if (f.Equals(p2))
                            {
                                ok1 = false;
                                break;
                            }
                            ok1 = true;
                        }
                    }
                    ok = ok1;
                    food.body = f;
                }

            
            food.Draw();
                score += ShowSpeed;
            }
            else
            {
                foreach(Point p in wall.body)
                {
                    if (snake.body[0].Equals(p))
                    {
                        snake.IsAlive = false;
                        break;
                    }
                }
                foreach(Point p in snake.body)
                {
                    if (p != snake.body[0] && p.Equals(snake.body[0]))
                    {
                        snake.IsAlive = false;
                        break;
                    }
                }
            }
            if (!snake.IsAlive)
            {
                return;
            }

            if(score >= (currentLevel+1) * 25)
            {
                currentLevel++;
                wall.Clear();
                wall.LoadLevel(currentLevel);
                snake.Clear2();
                snake.body.Clear();
                food.Clear();
                snake.body.Add(new Point { X = 35, Y = 11, Sign = '█' });
                snake.Draw();
                bool ok = false;
                while (!ok)
                {
                    bool ok1 = false;
                    Point f = food.Generate();
                    foreach (Point p1 in snake.body)
                    {
                        if (f.Equals(p1))
                        {
                            ok1 = false;
                            break;
                        }
                        ok1 = true;
                        foreach (Point p2 in wall.body)
                        {
                            if (f.Equals(p2))
                            {
                                ok1 = false;
                                break;
                            }
                            ok1 = true;
                        }
                    }
                    ok = ok1;
                    food.body = f;
                }
                food.Draw();
                wall.Draw();
                snake.Draw();
                snake.ChangeDirection(Console.ReadKey());
            }
            snake.Draw();
            StatusBar();


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

        void Sound()
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\Administrator\Desktop\final.wav");
            sp.Play();
        }

        void GameOver()
        {
            GameOver gameover = new GameOver();
            gameover.Show();
            string newname = gameover.Process();

            Record records = new Record();
            records.Add(newname, score);
        }

        public void Save()
        {
            snake.Save();
            SaveObj(score, "score");
            SaveObj(currentLevel, "currentLevel");
        }
        
        void SaveObj(int k, string fname)
        {
            FileStream fs = new FileStream(@"G:\Lessons\C sharp\github\Lab5\SnakeGame\Serialization\" + fname + ".txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(k);

            sw.Close();
            fs.Close();

        }

        int LoadObj(string fname)
        {
            FileStream fs = new FileStream(@"G:\Lessons\C sharp\github\Lab5\SnakeGame\Serialization\" + fname + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int val = int.Parse(sr.ReadLine());

            sr.Close();
            fs.Close();

            return val;

        }
        

    }
}
