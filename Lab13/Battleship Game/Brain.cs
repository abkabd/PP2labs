using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_Game
{
    public enum CellState
    {
        empty,
        busy,
        striked,
        missed,
        killed
    }

    public delegate void MyDelegate(CellState[,] map);

    public class Brain
    {
        CellState[,] map = new CellState[12, 12];
        List<Ship> units = new List<Ship>();
        MyDelegate showCells;

        public int stIndex = -1;
        public ShipType[] st = {
                                 ShipType.D4,
                                 ShipType.D3, ShipType.D3,
                                 ShipType.D2, ShipType.D2, ShipType.D2,
                                 ShipType.D1, ShipType.D1, ShipType.D1, ShipType.D1
                               };

        public Brain(MyDelegate showCells)
        {
            this.showCells = showCells;

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 12; ++j)
                {
                    map[i, j] = CellState.empty;
                }
            }
            showCells.Invoke(map);

        }


        public void PlaceShips(string msg)
        {
            string[] val = msg.Split('_');
            Point p = new Point(int.Parse(val[0]), int.Parse(val[1]));

            if (stIndex <= st.Length)
            {
                stIndex++;
                Ship ship = new Ship(p, st[stIndex]);
                if (IsGoodLocated(ship))
                {
                    units.Add(ship);
                    MarkLocation(ship);
                    showCells.Invoke(map);
                }

                else
                {
                    stIndex--;
                }
            }
        }

        private bool IsGoodLocated(Ship ship)
        {
            bool res = true;

            foreach (Point p in ship.body)
            {
                if (!IsGoodCell(p.X, p.Y))
                {
                    res = false;
                    break;
                }
            }

            return res;
        }

        private bool IsGoodCell(int i, int j)
        {
            if (i < 1 || i > 10) return false;
            if (j < 1 || j > 10) return false;
            if (map[i, j]         == CellState.busy) return false;
            if (map[i, j - 1]     == CellState.busy) return false;
            if (map[i, j + 1]     == CellState.busy) return false;
            if (map[i - 1, j]     == CellState.busy) return false;
            if (map[i + 1, j]     == CellState.busy) return false;
            if (map[i + 1, j - 1] == CellState.busy) return false;
            if (map[i + 1, j + 1] == CellState.busy) return false;
            if (map[i - 1, j - 1] == CellState.busy) return false;
            if (map[i - 1, j + 1] == CellState.busy) return false;
            return map[i, j] == CellState.empty;
        }

        private void MarkLocation(Ship ship)
        {
            foreach (Point p in ship.body)
            {
                map[p.X, p.Y] = CellState.busy;
            }
        }


        public bool Shoot(string msg)
        {
            bool successShoot = false;

            string[] val = msg.Split('_');
            int i = int.Parse(val[0]);
            int j = int.Parse(val[1]);

            switch (map[i, j])
            {
                case CellState.empty:
                    map[i, j] = CellState.missed;
                    break;

                case CellState.busy:
                    map[i, j] = CellState.striked;
                    successShoot = true;

                    int index = -1;
                    for (int k = 0; k < units.Count; ++k)
                    {
                        foreach (Point p in units[k].body)
                        {
                            if (p.X == i && p.Y == j)
                            {
                                index = k;
                                break;
                            }
                        }

                        if (index != -1)
                        {
                            break;
                        }

                    }

                    if (index != -1)
                    {
                        bool killed = true;


                        foreach (Point p in units[index].body)
                        {
                            if (map[p.X, p.Y] != CellState.striked)
                            {
                                killed = false;
                                break;
                            }
                        }

                        if (killed)
                        {

                            foreach (Point p in units[index].body)
                            {
                                int x = p.X;
                                int y = p.Y;
                                map[x, y - 1] = CellState.missed;
                                map[x - 1, y] = CellState.missed;
                                map[x, y + 1] = CellState.missed;
                                map[x + 1, y] = CellState.missed;
                                map[x - 1, y - 1] = CellState.missed;
                                map[x - 1, y + 1] = CellState.missed;
                                map[x + 1, y - 1] = CellState.missed;
                                map[x + 1, y + 1] = CellState.missed;
                            }

                            foreach (Point p in units[index].body)
                            {
                                map[p.X, p.Y] = CellState.killed;
                            }

                        }
                    }

                    break;
                case CellState.striked:
                    break;
                case CellState.missed:
                    break;
                case CellState.killed:
                    break;
                default:
                    break;
            }

            showCells.Invoke(map);
            return successShoot;
        }
    }


    
}
