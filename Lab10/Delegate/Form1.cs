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

namespace Delegate
{
    delegate double MyDelegate(double x, double y);
    public partial class Form1 : Form
    {
        MyDelegate md;
        CountSum sum = new CountSum();
        int _ticks;
        int time = 10;
        public Form1()
        {
            InitializeComponent();
            md = sum.Add;
            timer1.Interval = 400;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Process()
        {
            double num1;
            double num2;
            string firstNum = textBox1.Text;
            string secondNum = textBox2.Text;
            if (!double.TryParse(firstNum, out num1) || !double.TryParse(secondNum, out num2))
            {
                MessageBox.Show("Wrong format!", "", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("Sum = " + md.Invoke(num1, num2).ToString(), "", MessageBoxButtons.OK);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            label1.Text = (_ticks).ToString();
            if (_ticks - 1 == time)
            {
                label1.Text = "";
                timer1.Stop();
                Process();
            }
        }
    }
}
