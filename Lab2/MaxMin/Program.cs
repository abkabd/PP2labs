using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class ReadFile
    {
        public string value;
        public ReadFile(string path)
        {
            
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            value = sr.ReadToEnd();
            
            sr.Close();
            fs.Close();
        }

        public ReadFile() => value = null;
    }

    class MinMax
    {
        int mx = Int32.MinValue;
        int mn = Int32.MaxValue;
        string[] arr = null;

        public MinMax(string path)
        {
            ReadFile rd = new ReadFile(path);

            char[] splitters = { ' ', '\n', '\t', '\n' };
            arr = rd.value.Split(splitters);
            for (int i=0; i<arr.Length; i++)
            {
                int x;
                bool parse = int.TryParse(arr[i], out x);
                if (parse)
                {
                    mn = Math.Min(mn, x);
                    mx = Math.Max(mx, x);
                }
                
                
            }
        }
        
        public override string ToString()
        {
            string s1 = $"Minimum number is {this.mn}\n";
            string s2 = $"Maximum number is {this.mx}\n";
            return s1 + s2;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            string path = "input.txt";
            MinMax ans = new MinMax(path);
            Console.WriteLine(ans);
        }
    }
}
