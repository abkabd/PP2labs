using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_Game
{
    public partial class Form1 : Form
    {
        PlayerPanel p1, p2;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            p1 = new PlayerPanel(new Point(10, 10), PlayerType.Human);
            p2 = new PlayerPanel(new Point(400, 10), PlayerType.Bot);

            /*
             p1 = new PlayerPanel(PanelPosition.Left, PlayerType.Human, MakeBotTurn, PanelEnabled);
             p2 = new PlayerPanel(PanelPosition.Right, PlayerType.Bot, MakeBotTurn, PanelEnabled);
             * */
            this.Controls.Add(p1);
            this.Controls.Add(p2);
        }

        
        private void MakeBotTurn()
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 11);
            int j = rnd.Next(1, 11);
            while (p1.brain.Shoot(string.Format("{0}_{1}", i, j)))
            {
                Thread.Sleep(1000);
                i = rnd.Next(1, 11);
                j = rnd.Next(1, 11);
            }
        }
        

    }
}
