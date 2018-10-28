using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Menu
    {
        string[] items = {"    New game   ",
                          "    Continue   ",
                          "    Options    ",
                          "    Records    ",
                          "    Quit       "};

        int ItemsCount = 5;
        int selectedItem = 0;
        ConsoleColor selectedColor = ConsoleColor.Red;
        ConsoleColor unselectedColor = ConsoleColor.Yellow;
        int asdf=543;
        public void Start()
        {
            Console.ForegroundColor = unselectedColor;
            Console.SetCursorPosition(0, 0);
            DrawBorder();
            DrawTitle();
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
                                        NewGame();
                                        break;
                                    }
                                case 1:
                                    {
                                        //Continue();
                                        Continue();
                                        break;
                                    }
                                case 2:
                                    {
                                        //Options();
                                        Options();
                                        break;
                                    }
                                case 3:
                                    {
                                        //Records();
                                        Records();
                                        break;
                                    }
                                case 4:
                                    {
                                        //Quit();
                                        quit = Quit();
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

        void NewGame()
        {
            Game game = new Game();
            game.Start();
        }

        void Continue()
        {
            Game game = new Game(new Snake(0).Load());
            game.Start();
        }

        void Options()
        {
            Options options = new Options();
            options.Start();
        }
          
        void Records()
        {
            Record record = new Record();
            record.Show();
        }
        
        bool Quit()
        {
            Quit quit = new Quit();
            return quit.WantToQuit(); 
        }

        void Draw()
        {
            int posX = 32, posY = 14;
            Console.SetCursorPosition(posX, posY);
            for(int i=0; i<ItemsCount; i++)
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
