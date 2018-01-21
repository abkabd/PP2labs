using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius:");
            double r = double.Parse(Console.ReadLine().Replace('.', ','));
            Circle c = new Circle(r);
            c.PrintInfo();
        }
    }
}
