using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{

    class Program
    {
        static void Main(string[] args)
        {
            StandartSettings settings = new StandartSettings();
            Menu menu = new Menu();
            settings.Set();
            menu.Start();
        }
    }
}
