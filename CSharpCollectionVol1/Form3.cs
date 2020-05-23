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
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 1;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0) {
                num2 = 1;
                label1.Text = "" + num2;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true;
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 2;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0)
            {
                num2 = 2;
                label1.Text = "" + num2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 3;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0)
            {
                num2 = 3;
                label1.Text = "" + num2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 4;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0)
            {
                num2 = 4;
                label1.Text = "" + num2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 5;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0)
            {
                num2 = 5;
                label1.Text = "" + num2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 6;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0)
            {
                num2 = 6;
                label1.Text = "" + num2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 7;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0)
            {
                num2 = 7;
                label1.Text = "" + num2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 8;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0)
            {
                num2 = 8;
                label1.Text = "" + num2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 9;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0)
            {
                num2 = 9;
                label1.Text = "" + num2;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            opr = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            opr = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            opr = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            opr = 4;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (num1 != 0 && num2 != 0 && opr == 1)
            {
                ans = num1 + num2;
                label1.Text = "" + ans;
            } else if (num1 != 0 && num2 != 0 && opr == 2)
            {
                ans = num1 - num2;
                label1.Text = "" + ans;
            } else if (num1 != 0 && num2 != 0 && opr == 3)
            {
                ans = num1 * num2;
                label1.Text = "" + ans;
            } else if (num1 != 0 && num2 != 0 && opr == 4)
            {
                ans = num1 / num2;
                label1.Text = "" + ans;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            ans = 0;
            opr = 0;
            label1.Text = "0";
        }
    }
}
