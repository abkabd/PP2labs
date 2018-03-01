using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class GameOver
    {
        string name;
        string space;
        public void Show()
        {
            Console.Clear();
            Console.SetCursorPosition(35, 9);
            Console.WriteLine("Game Over!");
            Console.SetCursorPosition(30, 10);
            Console.Write("Enter your name, please: ");
            Console.SetCursorPosition(35, 12);
            Console.Write("|              |");
            Console.SetCursorPosition(36, 12);
            name = "PLAYER";
            space = "              ";
            Console.Write(name);
        }

        public string Process()
        {
            bool quit = false;
            ConsoleKeyInfo cki;
            while (!quit)
            {
                cki = Console.ReadKey(true);
                Console.SetCursorPosition(31, 13);
                Console.Write("                        ");
                switch (cki.Key)
                {
                    case ConsoleKey.Enter:
                        if(name.Length != 0)
                        {
                            quit = true;
                        }
                        else
                        {
                            Console.SetCursorPosition(31, 13);
                            Console.Write("Please, write your name!");
                        }
                        break;
                    case ConsoleKey.Backspace:
                        if(name.Length != 0)
                        {
                            name = name.Remove(name.Length - 1, 1);
                        }
                        break;
                    
                    default:
                        if(name.Length < 14)
                        {
                            name += cki.KeyChar;
                        }
                        break;
                }

                Console.SetCursorPosition(36, 12);
                Console.Write(space);
                Console.SetCursorPosition(36, 12);
                Console.Write(name);
            }
            return name;
        }
    }
}
