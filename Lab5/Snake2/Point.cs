using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public char sign { get; set; }

        public Point(int x, int y, char sign)
        {
            this.x = x;
            this.y = y;
            this.sign = sign;
        }

        public bool Equals(Point p)
        {
            return p.x == x && p.y == y;
        }
    }
}
