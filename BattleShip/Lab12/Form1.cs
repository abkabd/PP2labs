using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadGame();
        }

        private void LoadGame()
        {
            int x = 25;
            int y = 25;
            for(int i=1; i<=10; i++)
            {
                for(int j=1; j<=10; j++)
                {
                    Button btn = new Button();
                    btn.Name = ((char)(i + 64) + j).ToString();
                    btn.Location = new Point(i * x + y, j * x + y);
                    btn.Size = new Size(y, y);
                    btn.FlatAppearance.BorderSize = 1;
                    btn.TabStop = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.Blue;
                    Controls.Add(btn);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
