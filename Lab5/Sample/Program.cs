using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo cki;
            int x=0, y=0, dx = 1, dy = 0, speed = 250, addSpeed = 10, speedMax = 10, speedMin = 300;
            do
            {
                while (Console.KeyAvailable == false)
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.Write("█");
                    x += dx;
                    y += dy;

                    if (x >= Console.WindowWidth) { x = 0; }
                    if (x < 0) { x = Console.WindowWidth-1; }
                    if (y >= Console.WindowHeight) { y = 0; }
                    if (y < 0 ) { y = Console.WindowHeight-1; }

                    Thread.Sleep(speed);
                }

                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            dx = 0;
                            dy = -1;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            dx = 0;
                            dy = 1;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            dx = 1;
                            dy = 0;
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            dx = -1;
                            dy = 0;
                            break;
                        }
                    case ConsoleKey.Add:
                        {
                            speed -= addSpeed;
                            if(speed < speedMax)
                            {
                                speed = speedMax;
                            }
                            break;
                        }
                    case ConsoleKey.Subtract:
                        {
                            speed += addSpeed;
                            if(speed > speedMin)
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
        }
    }
}
