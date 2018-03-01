using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Complex
    {
        [XmlElement]
        public int a, b;

        public Complex()
        {
            a = 1;
            b = 1;
        }

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static int GCD(int p, int q)
        {
            if (q == 0)
            {
                return p;
            }

            int r = p % q;

            return GCD(q, r);
        }

        static Complex Normalize(Complex c)
        {
            int n = GCD(Math.Abs(c.a), Math.Abs(c.b));
            c.a = c.a / n;
            c.b = c.b / n;
            return c;
        }

        public void xsSave()
        {
            FileStream fs = new FileStream("complex.xml", FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            xs.Serialize(fs, this);
            fs.Close();
        }

        public static Complex xsLoad()
        {
            Complex x;
            FileStream fs = new FileStream("complex.xml", FileMode.Open, FileAccess.Read);
                
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            x = xs.Deserialize(fs) as Complex;
            fs.Close();
            return x;

        }

        public void bfSave()
        {
            using (FileStream fs = new FileStream(@"complex.bin", FileMode.Truncate, FileAccess.ReadWrite))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this);
                fs.Close();
            }
        }

        public static Complex bfLoad()
        {
            Complex x;
            using(FileStream fs = new FileStream(@"complex.bin", FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                x = bf.Deserialize(fs) as Complex;
                fs.Close();
            }
            return x;
            
        }
        public static Complex operator +(Complex x, Complex y)
        {
            Complex res = new Complex();
            res.a = x.a * y.b + x.b * y.a;
            res.b = x.b * y.b;

            res = Normalize(res);
            return res;
        }
        
        public override string ToString()
        {
            string s = null;
            if (b == 1)
            {
                s = $"{a}";
            }
            else if (b == 0)
            {
                s = "0";
            }
            else
            {
                s = $"{a}/{b}";
            }
            return s;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            /*
            string[] arr = null;

            Console.WriteLine("Enter first complex as x/y:");
            string s1 = Console.ReadLine();
            arr = s1.Split('/', ' ');
            Complex x = new Complex(int.Parse(arr[0]), int.Parse(arr[1]));

            Console.WriteLine("Enter second complex as x/y:");
            string s2 = Console.ReadLine();
            arr = s2.Split('/', ' ');
            Complex y = new Complex(int.Parse(arr[0]), int.Parse(arr[1]));

            Complex c = new Complex();
            c = x + y;

            
            Console.WriteLine(c);
            
            c.bfSave();
            c.xsSave();
            
            */
            Complex h = Complex.xsLoad();
            Console.WriteLine("XmlSerializer result: " + h);

            Complex g = Complex.bfLoad();
            Console.WriteLine("Binary Formatter result: " + g);
            
        }
    }
}

