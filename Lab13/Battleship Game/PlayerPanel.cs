using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_Game
{
    enum PlayerType
    {
        Human,
        Bot
    }
    public delegate void TurnDelegate();
    class PlayerPanel : Panel
    {
        public Brain brain;

        PlayerType pType;

        TurnDelegate tDelegate;
        int cell_sz = 30;
        public bool dir = true;
        public PlayerPanel(Point Location, PlayerType playerType, TurnDelegate tDelegate)
        {
            this.Location = Location;
            this.pType = playerType;
            this.tDelegate = tDelegate;

            Initialize();
        }


        private void Initialize()
        {
            CreateButtons();

            if (pType == PlayerType.Bot)
            {
                PlaceRandomShips();
            }
            if(pType == PlayerType.Human)
            {
                //PlaceRandomShips();
            }

        }

        public void PlaceRandomShips()
        {
            Random rnd1 = new Random(Guid.NewGuid().GetHashCode());
            Random rnd2 = new Random(Guid.NewGuid().GetHashCode());

            while (brain.stIndex < brain.st.Length - 1)
            {
                int i = rnd2.Next(1, 11);
                int j = rnd2.Next(1, 11);
                string msg = string.Format("{0}_{1}", i, j);
                brain.PlaceShips(msg, rnd1.Next(1, 100) < 55);
            }
        }

        private void CreateButtons()
        {
            //this.BackColor = Color.Aqua;
            this.Size = new Size(cell_sz * 12, cell_sz * 12);

            for (int i = 1; i <= 10; ++i)
            {
                for (int j = 1; j <= 10; ++j)
                {
                    Button btn = new Button();
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 2;
                    btn.Name = i + "_" + j;
                    btn.Click += Btn_Click;
                    btn.Size = new Size(cell_sz, cell_sz);
                    btn.Location = new Point(i * cell_sz, j * cell_sz);
                    this.Controls.Add(btn);
                }
            }
            brain = new Brain(ChangeButton);
        }
        

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            if (brain.stIndex < brain.st.Length - 1)
            {
                brain.PlaceShips(btn.Name, dir);
            }
            else
            {
                if (!brain.Shoot(btn.Name))
                {
                    tDelegate.Invoke();
                }
            }

        }

        private void ChangeButton(CellState[,] map)
        {
            Color shipColor = Color.White;

            if(pType == PlayerType.Human)
            {
                shipColor = Color.Blue;
            }
            if(pType == PlayerType.Bot)
            {
                shipColor = Color.White;
            }

            Image img = Image.FromFile(@"files/no.png");
            for (int i = 1; i <= 10; ++i)
            {
                for (int j = 1; j <= 10; ++j)
                {
                    Color colorToFill = Color.White;
                    bool isEnabled = true;

                    switch (map[i, j])
                    {
                        case CellState.empty:
                            colorToFill = Color.White;
                            img = Image.FromFile(@"files/no.png");
                            break;
                        case CellState.busy:
                            colorToFill = shipColor;
                            img = Image.FromFile(@"files/no.png");
                            break;
                        case CellState.striked:
                            colorToFill = Color.Yellow;
                            img = Image.FromFile(@"files/cross.png");
                            isEnabled = false;
                            break;
                        case CellState.missed:
                            colorToFill = Color.Gray;
                            img = Image.FromFile(@"files/dot.png");
                            isEnabled = false;
                            break;
                        case CellState.killed:
                            colorToFill = Color.Red;
                            img = Image.FromFile(@"files/cross.png");
                            isEnabled = false;
                            break;
                        default:
                            break;
                    }

                    this.Controls[10 * (i - 1) + j - 1].BackColor = colorToFill;
                    this.Controls[10 * (i - 1) + j - 1].Enabled = isEnabled;
                    if(img != null)
                    {
                        this.Controls[10 * (i - 1) + j - 1].BackgroundImageLayout = ImageLayout.Zoom;
                        this.Controls[10 * (i - 1) + j - 1].BackgroundImage = img;
                    }
                }
            }


        }

    }
}
