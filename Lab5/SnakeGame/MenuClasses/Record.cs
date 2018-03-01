using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Pair
    {
        public string F;
        public int S;
    }

    class Record
    {
        List<Pair> records;

        public void Add(string name, int score)
        {
            Read(name, score);
            Write();
        }
    
        void Read(string name, int score)
        {
            records = new List<Pair>();
            bool add = false;
            string name2;
            int score2;
            FileStream fs = new FileStream(@"G:\Lessons\C sharp\github\Lab5\SnakeGame\files\Records.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            while ((name2 = sr.ReadLine()) != null)
            {
                score2 = int.Parse(sr.ReadLine());
                if (!add && score >= score2)
                {
                    records.Add(new Pair { F = name, S = score });
                    add = true;
                }
                records.Add(new Pair { F = name2, S = score2 });
            }

            if (!add)
            {
                records.Add(new Pair { F = name, S = score });
            }

            sr.Close();
            fs.Close();
        }

        void Write()
        {
            FileStream fs = new FileStream(@"G:\Lessons\C sharp\github\Lab5\SnakeGame\files\Records.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(records[i].F);
                sw.WriteLine(records[i].S);
            }


            sw.Close();
            fs.Close();
        }

        public void Show()
        {
            Console.Clear();
            int posX = 20, posY = 6;
            DrawBorder(posX, posY);
            
            FileStream fs = new FileStream(@"G:\Lessons\C sharp\github\Lab5\SnakeGame\files\Records.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;

            Console.SetCursorPosition(posX + 7, posY + 1);
            Console.Write("Name:");
            Console.SetCursorPosition(posX + 26, posY + 1);
            Console.Write("Score:");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string name, score;
            int y = 4, n=1;
            while ((name = sr.ReadLine()) != null)
            {
                score = sr.ReadLine();

                Console.SetCursorPosition(posX + 1, posY + y);
                Console.Write(n++ + ")");
                Console.SetCursorPosition(posX + 5, posY + y);
                Console.Write(name);
                Console.SetCursorPosition(posX + 27, posY + y);
                Console.Write(score);

                y++;
            }


            sr.Close();
            fs.Close();
            
            Console.ReadKey();
        }

        void DrawBorder(int posX, int posY)
        {
        Console.Clear();
        FileStream fs = new FileStream(@"files\RecordBorder.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        string value;
            
        while((value = sr.ReadLine()) != null)
        {
            Console.SetCursorPosition(posX, posY++);
            Console.WriteLine(value);
        }
            
        sr.Close();
        fs.Close();
    }
    }
}
