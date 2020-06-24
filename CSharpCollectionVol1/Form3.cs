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
    public partial class Form3 : Form
    {
        public decimal num1;
        public decimal num2;
        public int opr;
        public decimal ans;
        public int num1done;

        void doButton(int button) {
            if (num1 == 0 && num1done == 0)
            {
                num1 = button;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num1done == 0)
            {
                num1 = (num1 * 10) + button;
                label1.Text = "" + num1;
            }
            else if (num2 == 0 && num1done == 1)
            {
                num2 = button;
                label1.Text = "" + num2;
            }
            else if (num2 != 0 && num1done == 1)
            {
                num2 = (num2 * 10) + button;
                label1.Text = "" + num2;
            }
        }

        public Form3()
        {
            InitializeComponent();
        }
        // "1" Button
        private void button1_Click(object sender, EventArgs e)
        {
            doButton(1);
        }
        // "Menu" Button
        private void button16_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true;
            Visible = false;
        }
        // "2" Button
        private void button2_Click(object sender, EventArgs e)
        {
            doButton(2);
        }
        // "3" Button
        private void button3_Click(object sender, EventArgs e)
        {
            doButton(3);
        }
        // "4" Button
        private void button4_Click(object sender, EventArgs e)
        {
            doButton(4);
        }
        // "5" Button
        private void button5_Click(object sender, EventArgs e)
        {
            doButton(5);
        }
        // "6" Button
        private void button6_Click(object sender, EventArgs e)
        {
            doButton(6);
        }
        // "7" Button
        private void button7_Click(object sender, EventArgs e)
        {
            doButton(7);
        }
        // "8" Button
        private void button8_Click(object sender, EventArgs e)
        {
            doButton(8);
        }
        // "9" Button
        private void button9_Click(object sender, EventArgs e)
        {
            doButton(9);
        }
        // "+" Button
        private void button12_Click(object sender, EventArgs e)
        {
            opr = 1;
            num1done = 1;
        }
        // "-" Button
        private void button13_Click(object sender, EventArgs e)
        {
            opr = 2;
            num1done = 1;
        }
        // "*" Button
        private void button15_Click(object sender, EventArgs e)
        {
            opr = 3;
            num1done = 1;
        }
        // "/" Button
        private void button14_Click(object sender, EventArgs e)
        {
            opr = 4;
            num1done = 1;
        }
        // "=" Button
        private void button17_Click(object sender, EventArgs e)
        {
            if (num1 != 0 && num2 != 0 && opr == 1 && num1done == 1)
            {
                ans = num1 + num2;
                label1.Text = "" + ans;
            } else if (num1 != 0 && num2 != 0 && opr == 2 && num1done == 1)
            {
                ans = num1 - num2;
                label1.Text = "" + ans;
            } else if (num1 != 0 && num2 != 0 && opr == 3 && num1done == 1)
            {
                ans = num1 * num2;
                label1.Text = "" + ans;
            } else if (num1 != 0 && num2 != 0 && opr == 4 && num1done == 1)
            {
                ans = num1 / num2;
                label1.Text = "" + ans;
            }
        }
        // "Clear" Button
        private void button11_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            ans = 0;
            opr = 0;
            label1.Text = "0";
            num1done = 0;
        }
        // "0" Button
        private void button10_Click(object sender, EventArgs e)
        {
            if (num1 != 0 && num1done == 0)
            {
                num1 = num1 * 10;
                label1.Text = "" + num1;
            }
            else if (num2 != 0 && num1done == 1)
            {
                num2 = num2 * 10;
                label1.Text = "" + num2;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
