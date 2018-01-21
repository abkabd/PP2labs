using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace File
{
    class Program
    {
        static void PrintFrameUp()
        {
            string x = "                           ";
            string s1 = " ______________________________________________________";
            string s2 = "│ ____________________________________________________ │";
            string s3 = "││ __________________________________________________ ││";
            string s4 = "│││                                                  │││";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{x}{s1}\n{x}{s2}\n{x}{s3}\n{x}{s4}");
        }

        static void PrintFrameDown()
        {
            string x = "                           ";
            string s1 = "│││__________________________________________________│││";
            string s2 = "││____________________________________________________││";
            string s3 = "│______________________________________________________│";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{x}{s1}\n{x}{s2}\n{x}{s3}\n");
        }

        static void SetTextColor(char x)
        {
            if (x == 'W')
            {

                Console.ForegroundColor = ConsoleColor.White;
            }
            if(x == 'R')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if(x == 'Y')
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        static void PrintName(string s, char x)
        {
            string t = null;
            string t1 = "               ";
            string ss = null;
            bool ok = false;
            string a = "│││";
            for (int i = 0; i < 35 - s.Length; i++)
            {
                t += ' ';
            }

            if (s.Length >= 35)
            {
                ok = true;
                for (int i = 0; i < 33; i++)
                {
                    ss += s[i];
                }
                ss += "..";
            }
            if (ok) s = null;

            SetTextColor('R');
            Console.Write(a);
            SetTextColor(x);
            Console.Write(t1 + ss + s + t);
            SetTextColor('R');
            Console.Write(a);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }

        static void HighightBackground(int index, int pos)
        {
            if (pos == index)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        static void PrintDir(int index, DirectoryInfo[] dirs, FileInfo[] files)
        {
            Console.Clear();

            PrintFrameUp();
            Console.Write("                           ");
            SetTextColor('W');
            HighightBackground(index, -1);
            PrintName("...", 'W');
            for(int i=0; i<dirs.Length; i++)
            {
                Console.Write("                           ");
                HighightBackground(index, i);
                PrintName(dirs[i].Name, 'W');

            }

            for(int i=0; i<files.Length; i++)
            {
                Console.Write("                           ");
                HighightBackground(index, i + dirs.Length);
                PrintName(files[i].Name, 'Y');
            }
            Console.BackgroundColor = ConsoleColor.Black;
            PrintFrameDown();
        }

        static bool WantToExit()
        {
            Console.Clear();
            PrintFrameUp();
            Console.Write("                           ");
            PrintName("Want to exit?", 'Y');
            Console.Write("                           ");
            PrintName("YES", 'W');
            Console.Write("                           ");
            PrintName("NO", 'W');
            PrintFrameDown();
            return true;
        }
        
        static void Recur(int index, string path, int outLen)
        {
            DirectoryInfo d = new DirectoryInfo(@path);
            DirectoryInfo[] dirs = d.GetDirectories();
            FileInfo[] files = d.GetFiles();

            string newPath = null;

            int n = dirs.Length + files.Length;
            bool quit = false;
            while (!quit)
            {
                PrintDir(index, dirs, files);

                ConsoleKeyInfo pressedKey = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            index--;
                            if (index < -1) index = n - 1;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            index++;
                            if (index >= n) index = -1;
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            if (index == -1)
                            {
                                if(path.Length < outLen)
                                {
                                    quit = WantToExit();
                                    break;
                                }
                                int pos = path.LastIndexOf('\\');
                                newPath = path;
                                newPath = newPath.Remove(pos, newPath.Length - pos);
                            }
                            else if (index < dirs.Length)
                            {
                                newPath = dirs[index].FullName;
                            }
                            else
                            {
                                newPath = files[index - dirs.Length].FullName;
                            }

                            if (index < dirs.Length)
                            {
                                Recur(-1, newPath, outLen);
                            }
                            break;
                        }

                    case ConsoleKey.Escape:
                        {
                            quit = true;
                            break;
                        }
                        

                }
            }
            return;
        }

        static void Main()
        {
            string path = @"G:\Lessons";

            Recur(-1, path, path.Length);
            
        }
    }
}
