using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCollectionVol1
{
    public partial class Form5 : Form
    {
        public int player;
        public int xwins;
        public int owins;

        public Form5()
        {
            InitializeComponent();
            player = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (player == 1)
            {
                label1.Text = "X";
                player = 2;
            }
            else if (player == 2)
            {
                label1.Text = "O";
                player = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            if (player == 1)
            {
                label2.Text = "X";
                player = 2;
            }
            else if (player == 2)
            {
                label2.Text = "O";
                player = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            if (player == 1)
            {
                label3.Text = "X";
                player = 2;
            }
            else if (player == 2)
            {
                label3.Text = "O";
                player = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            if (player == 1)
            {
                label4.Text = "X";
                player = 2;
            }
            else if (player == 2)
            {
                label4.Text = "O";
                player = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            if (player == 1)
            {
                label5.Text = "X";
                player = 2;
            }
            else if (player == 2)
            {
                label5.Text = "O";
                player = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            if (player == 1)
            {
                label6.Text = "X";
                player = 2;
            }
            else if (player == 2)
            {
                label6.Text = "O";
                player = 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            if (player == 1)
            {
                label7.Text = "X";
                player = 2;
            }
            else if (player == 2)
            {
                label7.Text = "O";
                player = 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            if (player == 1)
            {
                label8.Text = "X";
                player = 2;
            }
            else if (player == 2)
            {
                label8.Text = "O";
                player = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            if (player == 1)
            {
                label9.Text = "X";
                player = 2;
            }
            else if (player == 2)
            {
                label9.Text = "O";
                player = 1;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true;
            Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            player = 1;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            xwins = 0;
            owins = 0;
            label10.Text = "X " + xwins + " - " + owins + " O";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            xwins = xwins + 1;
            label10.Text = "X " + xwins + " - " + owins + " O";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            owins = owins + 1;
            label10.Text = "X " + xwins + " - " + owins + " O";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (xwins < owins)
            {
                string message = "O Wins!";
                string title = "Game Over!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    player = 1;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                    button6.Visible = true;
                    button7.Visible = true;
                    button8.Visible = true;
                    button9.Visible = true;
                    xwins = 0;
                    owins = 0;
                    label10.Text = "X " + xwins + " - " + owins + " O";
                }
            }
            else if (xwins > owins)
            {
                string message = "X Wins!";
                string title = "Game Over!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    player = 1;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                    button6.Visible = true;
                    button7.Visible = true;
                    button8.Visible = true;
                    button9.Visible = true;
                    xwins = 0;
                    owins = 0;
                    label10.Text = "X " + xwins + " - " + owins + " O";
                }
            }
        }
    }
}
