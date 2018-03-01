using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class StandartSettings
    {
        int WindowH = 30;
        int WindowW = 80;
        ConsoleColor BaseColor = ConsoleColor.DarkBlue;
        ConsoleColor TextColor = ConsoleColor.Yellow;

        public static int Speed { get; set; }
        public static ConsoleColor snakeColor { get; set; }
        /*

         * Screen color is DarkBlue
         * Snake color is Green
         * Food color is Red
         * Mega food color is White
         
        */

        public void Set()
        {
            Speed = 200;
            snakeColor = ConsoleColor.Green;
            Console.CursorVisible = false;
            Console.BackgroundColor = BaseColor;
            Console.ForegroundColor = TextColor;
            Console.SetWindowSize(WindowW, WindowH);
            Console.SetBufferSize(WindowW, WindowH);
        }

        /*
        public void View()
        {
            //Food
            Console.ForegroundColor = FoodColor;
            Console.WriteLine("Food: ");
            Console.WriteLine("$");

            //Megafood
            Console.ForegroundColor = MegaFoodColor;
            Console.WriteLine("Megafood: ");
            Console.WriteLine("        ████");
            Console.WriteLine("        ████");

            //Snake
            Console.ForegroundColor = SnakeBodyColor;
            Console.WriteLine("Snake: ");
            Console.Write("█████████████");
            /*
            Console.WriteLine("█");
            Console.WriteLine("█");
            Console.WriteLine("█");
            Console.WriteLine("█");
            Console.WriteLine("█");
            Console.WriteLine("█");
            *
            Console.ForegroundColor = SnakeHeadColor;
            Console.WriteLine("█");

            //Text
            Console.ForegroundColor = TextColor;
            Console.WriteLine("Text:");
            Console.WriteLine("      Snake Game!");
        }
        */
    }
}
