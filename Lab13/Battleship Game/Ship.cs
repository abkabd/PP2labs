using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_Game
{
    public enum ShipType
    {
        D1,
        D2,
        D3,
        D4
    }
    public enum ShipDirection
    {
        Horizontal,
        Vertical
    }

    public class Ship
    {
        public List<Point> body = new List<Point>();
        ShipType type;
        ShipDirection direction;

        public Ship(Point p, ShipType type)
        {
            this.type = type;
            this.direction = ShipDirection.Horizontal;

            GenerateBody(p);
        }
        public void GenerateBody(Point p)
        {
            int[] dx = new int[4];
            int[] dy = new int[4];
            int N = 0;

            switch (direction)
            {
                case ShipDirection.Horizontal:
                    dx = new int[] { 0, 1, 2, 3 };
                    dy = new int[] { 0, 0, 0, 0 };
                    break;
                case ShipDirection.Vertical:
                    dx = new int[] { 0, 0, 0, 0 };
                    dy = new int[] { 0, 1, 2, 3 };
                    break;
                default:
                    break;
            }

            switch (type)
            {
                case ShipType.D1:
                    N = 1;
                    break;
                case ShipType.D2:
                    N = 2;
                    break;
                case ShipType.D3:
                    N = 3;
                    break;
                case ShipType.D4:
                    N = 4;
                    break;
                default:
                    break;
            }

            for (int i = 0; i < N; i++)
            {
                body.Add(new Point { X = p.X + dx[i], Y = p.Y + dy[i] });
            }
        }
    }
}
