using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class fCalc : Form
    {
        public fCalc()
        {
            InitializeComponent();
            txtScreen.Text = "0";
        }

        private void fCalc_Load(object sender, EventArgs e)
        {
        }
        

        private void num_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (txtScreen.Text.Length >= 16)
            {
                return;
            }

            if (btn.Text == "," && !txtScreen.Text.Contains(","))
            {
                txtScreen.Text += btn.Text;
            }
            else if (btn.Text != ",")
            {
                if (txtScreen.Text == "0")
                {
                    txtScreen.Clear();
                }
                txtScreen.Text += btn.Text;
            }
        }
        
        private void num_Press(object sender, KeyPressEventArgs e)
        {
            char pressedKey = e.KeyChar;

            if (txtScreen.Text.Length >= 16)
            {
                return;
            }
            if(!((pressedKey >= '0' && pressedKey <= '9') || pressedKey == '.' || pressedKey == ','))
            {
                return;
            }
            if(pressedKey == '.')
            {
                pressedKey = ',';
            }

            if (pressedKey == ',' && !txtScreen.Text.Contains(","))
            {
                txtScreen.Text += pressedKey;
            }
            else if (pressedKey != ',')
            {
                if (txtScreen.Text == "0")
                {
                    txtScreen.Clear();
                }
                txtScreen.Text += pressedKey;
            }
            
            
        }

        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                txtScreen.Text = "0";
            }
        }

        private void command_CLick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == "C")
            {
                txtScreen.Text = "0";
            }
            //←
            if (btn.Text == "←" && txtScreen.Text != "0")
            {
                txtScreen.Text = txtScreen.Text.Remove(txtScreen.Text.Length - 1, 1);

                if(txtScreen.Text.Length == 0)
                {
                    txtScreen.Text += '0';
                }
            }


        }
    }
}




