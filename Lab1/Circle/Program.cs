using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        class Circle
        {
            double r;

            public Circle()
            {
                r = 0;
            }

            public Circle(double r)
            {
                this.r = r;
            }

            double Diam()
            {
                return 2 * r;
            }

            double Circum()
            {
                return 2 * 3.14 * r;
            }

            double Area()
            {
                return 3.14 * r * r;
            }

            public void PrintInfo()
            {
                Console.WriteLine("Radius of a circle is {0}", r);
                Console.WriteLine("Diameter of a circle is {0}", Diam());
                Console.WriteLine("Circumference of a circle is {0}", Circum());
                Console.WriteLine("Area of a circle is {0}", Area());
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius:");
            double r = double.Parse(Console.ReadLine().Replace('.', ','));
            Circle c = new Circle(r);
            c.PrintInfo();

        }
    }
}
