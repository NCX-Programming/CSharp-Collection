using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CSharpCollectionVol1
{
    public partial class Form2 : Form
    {
        public int clickcount;

        public Form2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
                f.Visible = true;
                Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickcount = clickcount + 1;
            label2.Text = "You've clicked " + clickcount + " time(s)!";
            pictureBox1.BackColor = Color.Red;
            label1.BackColor = Color.Red;
            label1.Text = "Red";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickcount = clickcount + 1;
            label2.Text = "You've clicked " + clickcount + " time(s)!";
            pictureBox1.BackColor = Color.Orange;
            label1.BackColor = Color.Orange;
            label1.Text = "Orange";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickcount = clickcount + 1;
            label2.Text = "You've clicked " + clickcount + " time(s)!";
            pictureBox1.BackColor = Color.Yellow;
            label1.BackColor = Color.Yellow;
            label1.Text = "Yellow";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickcount = clickcount + 1;
            label2.Text = "You've clicked " + clickcount + " time(s)!";
            pictureBox1.BackColor = Color.Lime;
            label1.BackColor = Color.Lime;
            label1.Text = "Lime";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickcount = clickcount + 1;
            label2.Text = "You've clicked " + clickcount + " time(s)!";
            pictureBox1.BackColor = Color.Blue;
            label1.BackColor = Color.Blue;
            label1.Text = "Blue";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clickcount = clickcount + 1;
            label2.Text = "You've clicked " + clickcount + " time(s)!";
            pictureBox1.BackColor = Color.Purple;
            label1.BackColor = Color.Purple;
            label1.Text = "Purple";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickcount = 0;
            label2.Text = "You've clicked 0 time(s)!";
            pictureBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label1.Text = "White";
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
