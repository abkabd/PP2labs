using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    /// <summary>
    /// Class containing main functions of circle
    /// </summary>
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
        /// <summary>
        /// Diameter of a circle
        /// </summary>
        /// <returns>Diameter of a circle</returns>
        double Diam()
        {
            return 2 * r;
        }
        /// <summary>
        /// Circumference of a circle
        /// </summary>
        /// <returns>Circumference of a circle</returns>
        double Circum()
        {
            return (double)2 * Math.PI * r;
        }

        /// <summary>
        /// Area of a circle
        /// </summary>
        /// <returns>Area of a circle</returns>
        double Area()
        {
            return (double)Math.PI * r * r;
        }

        /// <summary>
        /// Information about object of Circle class
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine("Radius of a circle is {0:F2}", r);
            Console.WriteLine("Diameter of a circle is {0:F2}", Diam());
            Console.WriteLine("Circumference of a circle is {0:F2}", Circum());
            Console.WriteLine("Area of a circle is {0:F2}", Area());
        }
    }
}
