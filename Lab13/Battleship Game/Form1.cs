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
            this.Size = new Size(420, 450);

            p1 = new PlayerPanel(new Point(10, 10), PlayerType.Human, MakeBotTurn);
            p2 = new PlayerPanel(new Point(400, 10), PlayerType.Bot, MakeBotTurn);

            /*
             p1 = new PlayerPanel(PanelPosition.Left, PlayerType.Human, MakeBotTurn, PanelEnabled);
             p2 = new PlayerPanel(PanelPosition.Right, PlayerType.Bot, MakeBotTurn, PanelEnabled);
             * */
            this.Controls.Add(p1);
            this.Controls.Add(p2);

            p1.Enabled = true;
            p2.Enabled = false;

            checkBox2.Checked = true;
            timer1.Start();
        }

        
        private void MakeBotTurn()
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 11);
            int j = rnd.Next(1, 11);
            while (p1.brain.Shoot(string.Format("{0}_{1}", i, j)))
            {
                p2.Enabled = false;
                i = rnd.Next(1, 11);
                j = rnd.Next(1, 11);
                Thread.Sleep(1000);
                p2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1.PlaceRandomShips();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            p1.dir = checkBox2.Checked;
            if(p1.brain.stIndex >= p1.brain.st.Length - 1)
            {
                p1.Enabled = false;
                p2.Enabled = true;
                checkBox2.Hide();
                button1.Hide();
                this.Size = new Size(800, 420);
                this.Location = new Point(Location.X + 20, Location.Y);
                timer1.Stop();
            }
        }

    }
}
