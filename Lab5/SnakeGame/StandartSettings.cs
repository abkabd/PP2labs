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
        ConsoleColor SnakeBodyColor = ConsoleColor.Green;
        ConsoleColor SnakeHeadColor = ConsoleColor.Black;
        ConsoleColor TextColor = ConsoleColor.Yellow;
        ConsoleColor FoodColor = ConsoleColor.Red;
        ConsoleColor MegaFoodColor = ConsoleColor.White;

        /*

         * Screen color is DarkBlue
         * Snake color is Green
         * Food color is Red
         * Mega food color is White
         
        */

        public void Set()
        {
            Console.CursorVisible = true;
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
