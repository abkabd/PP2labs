using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastPrime
{
    class File
    {
        public string value;
        public File() => value = null;

        public void Read(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            value = sr.ReadToEnd();

            sr.Close();
            fs.Close();
        }

        public void Write(string path, string ans)
        {
            FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(ans);

            sw.Close();
            fs.Close();
        } 
    }

    class MinPrime
    {
        int pr = int.MaxValue;

        public MinPrime(string path)
        {
            File rd = new File();
            rd.Read(path);

            char[] splitters = { ' ', '\n', '\t', '\n'};
            string[] arr = rd.value.Split(splitters);
            for (int i = 0; i < arr.Length; i++)
            {
                int x;
                bool parse = int.TryParse(arr[i], out x);
                if (parse && IsPrime(x))
                {
                    pr = Math.Min(pr, x);
                }

            }
        }

        bool IsPrime(int x)
        {
            if (x < 2)
            {
                return false;
            }

            for(int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public string Write()
        {
            string s;
            if(this.pr == int.MaxValue)
            {
                s = "No primes in your list";
            }
            else
            {
                s = $"Minimum prime number in your list is {this.pr}";
            }
            return s;
        }
        
    }

    
    class Program
    {

        static void Main(string[] args)
        {
            string InPath = "input.txt";
            string OutPath = @"G:\Lessons\C sharp\github\Lab2\LeastPrime\output.txt";
            MinPrime k = new MinPrime(InPath);
            new File().Write(OutPath, k.Write());
            
        }
    }
}
