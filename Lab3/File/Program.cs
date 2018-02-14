using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace File
{
    class Program
    {
        static void PrintFrameUp()
        {
            string x = "";// "                           ";
            string s1 = " ______________________________________________________";
            string s2 = "│ ____________________________________________________ │";
            string s3 = "││ __________________________________________________ ││";
            string s4 = "│││                                                  │││";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{x}{s1}\n{x}{s2}\n{x}{s3}\n{x}{s4}");
        }

        static void PrintFrameDown()
        {
            string x = "";// "                           ";
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
            if (x == 'R')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (x == 'Y')
            {

                Console.ForegroundColor = ConsoleColor.Green;
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
            Console.BackgroundColor = ConsoleColor.DarkBlue;
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
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }

        static void PrintDir(int index, DirectoryInfo[] dirs, FileInfo[] files)
        {
            List<FileSystemInfo> arr = new List<FileSystemInfo>();
            arr.AddRange(dirs);
            arr.AddRange(files);
            Thread.Sleep(0);
            PrintFrameUp();

            int n = 10;
            int pos = index / n;
            pos *= n;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            if (index < n)
            {
                //Console.Write("                           ");
                SetTextColor('W');
                HighightBackground(index, -1);
                PrintName("...", 'W');
            }

            for (int i = pos; i < pos + 10; i++)
            {

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                if (i >= arr.Count)
                {
                    break;
                }
                //Console.Write("                           ");
                HighightBackground(index, i);
                if (arr[i].GetType() == typeof(DirectoryInfo))
                {
                    PrintName(arr[i].Name, 'W');
                }
                else
                {
                    PrintName(arr[i].Name, 'Y');
                }

            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            PrintFrameDown();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(25, 2);
            Console.WriteLine($"Page {index / n + 1}");
        }

        static void ShowFile(string path)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            Console.WriteLine(sr.ReadToEnd());

            sr.Close();
            fs.Close();
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
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
                Console.SetCursorPosition(0, 0);
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
                                if (path.Length < outLen)
                                {
                                    quit = true;
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
                            Console.Clear();
                            if (index < dirs.Length)
                            {
                                Recur(-1, newPath, outLen);
                            }
                            else
                            {
                                ShowFile(newPath);
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                    case ConsoleKey.Backspace:
                        {
                            quit = true;
                            break;
                        }

                }
            }
            Console.Clear();
            return;
        }

        static void Main()
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            ShowFile("input.txt");
            string path = @"G:\Lessons\Programming";
            string path2 = @"C:\Users\Administrator\Desktop\chch";
            Recur(-1, path2, path2.Length);

        }
    }
}