using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Options
    {
        string[] items = {"     Speed     ",
                          "     Color     ",
                          "     Back      "};

        int ItemsCount = 3;
        int selectedItem = 0;
        ConsoleColor selectedColor = ConsoleColor.Red;
        ConsoleColor unselectedColor = ConsoleColor.Yellow;

        public void Start()
        {
            Console.Clear();
            
            DrawBorder();
            DrawTitle();
            Draw();
            Console.ForegroundColor = unselectedColor;
            Console.SetCursorPosition(0, 0);
            ConsoleKeyInfo button = new ConsoleKeyInfo();
            bool quit = false;
            while (!quit)
            {
                Draw();
                button = Console.ReadKey(true);

                switch (button.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            selectedItem--;
                            if (selectedItem < 0) { selectedItem = ItemsCount - 1; }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            selectedItem++;
                            if (selectedItem >= ItemsCount) { selectedItem = 0; }
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            switch (selectedItem)
                            {
                                case 0:
                                    {
                                        //NewGame();
                                        Speed();
                                        break;
                                    }
                                case 1:
                                    {
                                        //Continue();
                                        Color();
                                        break;
                                    }
                                case 2:
                                    {
                                        quit = true;
                                        break;
                                    }
                            }

                            if (!quit)
                            {
                                DrawBorder();
                                DrawTitle();
                            }
                            break;
                        }
                    default:
                        break;
                }


            }
        }

        void Color()
        {
            string[] items = {"     Green     ",
                              "     Red       ",
                              "     Cyan      ",};

            int ItemsCount = 3;
            int selectedItem = 0;
            

            ConsoleKeyInfo button;
            bool quit = false;
            while (!quit)
            {
                DrawColor(items, ItemsCount, selectedItem);
                button = Console.ReadKey(true);

                switch (button.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            selectedItem--;
                            if (selectedItem < 0) { selectedItem = ItemsCount - 1; }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            selectedItem++;
                            if (selectedItem >= ItemsCount) { selectedItem = 0; }
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            quit = true;
                            switch (selectedItem)
                            {
                                case 0:
                                    {
                                        StandartSettings.snakeColor = ConsoleColor.Green;
                                        break;
                                    }
                                case 1:
                                    {
                                        StandartSettings.snakeColor = ConsoleColor.Red;
                                        break;
                                    }
                                case 2:
                                    {
                                        StandartSettings.snakeColor = ConsoleColor.Cyan;
                                        break;
                                    }
                            }

                            if (!quit)
                            {
                                DrawBorder();
                                DrawTitle();
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        void DrawColor(string[] items, int itemsCount, int selectedItem)
        {
            ConsoleColor selectedColor = ConsoleColor.Magenta;
            ConsoleColor unselectedColor = ConsoleColor.DarkBlue;
            int posX = 32, posY = 14;
            Console.SetCursorPosition(posX, posY);
            for (int i = 0; i < ItemsCount; i++)
            {

                Console.SetCursorPosition(posX, posY + i);
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                if (selectedItem == i)
                {
                    Console.BackgroundColor = selectedColor;
                }
                else
                {
                    Console.BackgroundColor = unselectedColor;
                }

                Console.Write(items[i]);
                Console.BackgroundColor = unselectedColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (selectedItem == i)
                {
                    Console.BackgroundColor = selectedColor;
                    Console.SetCursorPosition(posX + 2, posY + i);
                    Console.Write(">>");
                    Console.BackgroundColor = unselectedColor;
                }
            }
        }

        void Speed()
        {
            Console.Clear();
            DrawBorder();
            DrawTitle();
            bool quit = false;
            int spd = 11 - StandartSettings.Speed / 20;
            ConsoleKeyInfo cki;
            while (!quit)
            {

                int posX = 32, posY = 15;
                Console.SetCursorPosition(posX - 8, posY - 1);
                Console.Write("Your current speed is:    / 10");
                Console.SetCursorPosition(posX + 16, posY - 1);
                Console.Write(spd);

                int x = 35, y = 18;
                Console.SetCursorPosition(x, y);
                Console.Write("             ");
                Console.BackgroundColor = ConsoleColor.Yellow;
                for (int i=0; i<spd; i++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(' ');
                    Console.SetCursorPosition(x, y+1);
                    Console.Write(spd);
                    Console.SetCursorPosition(35, 19);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                    Console.Write("             ");
                    Console.BackgroundColor = ConsoleColor.Yellow;

                    x++;
                }
                Console.BackgroundColor = ConsoleColor.DarkBlue;

                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        spd--;
                        if(spd == 0)
                        {
                            spd = 1;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        spd++;
                        if(spd == 11)
                        {
                            spd = 10;
                        }
                        break;
                    case ConsoleKey.Enter:
                        StandartSettings.Speed = 20 * (11 - spd);
                        quit = true;
                        break;
                }
            }
        }

        void Draw()
        {
            int posX = 32, posY = 14;
            Console.SetCursorPosition(posX, posY);
            for (int i = 0; i < ItemsCount; i++)
            {

                Console.SetCursorPosition(posX, posY + i);
                Console.Write("│");
                if (selectedItem == i)
                {
                    Console.ForegroundColor = selectedColor;
                }
                else
                {
                    Console.ForegroundColor = unselectedColor;
                }

                Console.Write(items[i]);
                Console.ForegroundColor = unselectedColor;
                Console.Write("│");

                if (selectedItem == i)
                {
                    Console.ForegroundColor = selectedColor;
                    Console.SetCursorPosition(posX + 2, posY + i);
                    Console.Write(">>");
                    Console.ForegroundColor = unselectedColor;
                }
            }
        }

        void DrawTitle()
        {

            FileStream fs = new FileStream(@"files\Title.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string value;
            int y = 4;
            while ((value = sr.ReadLine()) != null)
            {
                Console.SetCursorPosition(10, y++);
                Console.WriteLine(value);
            }

            sr.Close();
            fs.Close();

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
