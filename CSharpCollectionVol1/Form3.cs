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
        
        public Form3()
        {
            InitializeComponent();
        }
        // "1" Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && num1done == 0)
            {
                num1 = 1;
                label1.Text = "" + num1;
            }
            else if (num1 == 1 && num1done == 0)
            {
                num1 = 11;
                label1.Text = "" + num1;
            }
            else if (num1 == 2 && num1done == 0)
            {
                num1 = 21;
                label1.Text = "" + num1;
            }
            else if (num1 == 3 && num1done == 0)
            {
                num1 = 31;
                label1.Text = "" + num1;
            }
            else if (num1 == 4 && num1done == 0)
            {
                num1 = 41;
                label1.Text = "" + num1;
            }
            else if (num1 == 5 && num1done == 0)
            {
                num1 = 51;
                label1.Text = "" + num1;
            }
            else if (num1 == 6 && num1done == 0)
            {
                num1 = 61;
                label1.Text = "" + num1;
            }
            else if (num1 == 7 && num1done == 0)
            {
                num1 = 71;
                label1.Text = "" + num1;
            }
            else if (num1 == 8 && num1done == 0)
            {
                num1 = 81;
                label1.Text = "" + num1;
            }
            else if (num1 == 9 && num1done == 0)
            {
                num1 = 91;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0 && num1done == 1)
            {
                num2 = 1;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 1 && num1done == 1)
            {
                num2 = 11;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 2 && num1done == 1)
            {
                num2 = 21;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 3 && num1done == 1)
            {
                num2 = 31;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 4 && num1done == 1)
            {
                num2 = 41;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 5 && num1done == 1)
            {
                num2 = 51;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 6 && num1done == 1)
            {
                num2 = 61;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 7 && num1done == 1)
            {
                num2 = 71;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 8 && num1done == 1)
            {
                num2 = 81;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 9 && num1done == 1)
            {
                num2 = 91;
                label1.Text = "" + num2;
            }
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
            if (num1 == 0)
            {
                num1 = 2;
                label1.Text = "" + num1;
            }
            else if (num1 == 1 && num1done == 0)
            {
                num1 = 12;
                label1.Text = "" + num1;
            }
            else if (num1 == 2 && num1done == 0)
            {
                num1 = 22;
                label1.Text = "" + num1;
            }
            else if (num1 == 3 && num1done == 0)
            {
                num1 = 32;
                label1.Text = "" + num1;
            }
            else if (num1 == 4 && num1done == 0)
            {
                num1 = 42;
                label1.Text = "" + num1;
            }
            else if (num1 == 5 && num1done == 0)
            {
                num1 = 52;
                label1.Text = "" + num1;
            }
            else if (num1 == 6 && num1done == 0)
            {
                num1 = 62;
                label1.Text = "" + num1;
            }
            else if (num1 == 7 && num1done == 0)
            {
                num1 = 72;
                label1.Text = "" + num1;
            }
            else if (num1 == 8 && num1done == 0)
            {
                num1 = 82;
                label1.Text = "" + num1;
            }
            else if (num1 == 9 && num1done == 0)
            {
                num1 = 92;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0 && num1done == 1)
            {
                num2 = 2;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 1 && num1done == 1)
            {
                num2 = 12;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 2 && num1done == 1)
            {
                num2 = 22;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 3 && num1done == 1)
            {
                num2 = 32;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 4 && num1done == 1)
            {
                num2 = 42;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 5 && num1done == 1)
            {
                num2 = 52;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 6 && num1done == 1)
            {
                num2 = 62;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 7 && num1done == 1)
            {
                num2 = 72;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 8 && num1done == 1)
            {
                num2 = 82;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 9 && num1done == 1)
            {
                num2 = 92;
                label1.Text = "" + num2;
            }
        }
        // "3" Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 3;
                label1.Text = "" + num1;
            }
            else if (num1 == 1 && num1done == 0)
            {
                num1 = 13;
                label1.Text = "" + num1;
            }
            else if (num1 == 2 && num1done == 0)
            {
                num1 = 23;
                label1.Text = "" + num1;
            }
            else if (num1 == 3 && num1done == 0)
            {
                num1 = 33;
                label1.Text = "" + num1;
            }
            else if (num1 == 4 && num1done == 0)
            {
                num1 = 43;
                label1.Text = "" + num1;
            }
            else if (num1 == 5 && num1done == 0)
            {
                num1 = 53;
                label1.Text = "" + num1;
            }
            else if (num1 == 6 && num1done == 0)
            {
                num1 = 63;
                label1.Text = "" + num1;
            }
            else if (num1 == 7 && num1done == 0)
            {
                num1 = 73;
                label1.Text = "" + num1;
            }
            else if (num1 == 8 && num1done == 0)
            {
                num1 = 83;
                label1.Text = "" + num1;
            }
            else if (num1 == 9 && num1done == 0)
            {
                num1 = 93;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0 && num1done == 1)
            {
                num2 = 3;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 1 && num1done == 1)
            {
                num2 = 13;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 2 && num1done == 1)
            {
                num2 = 23;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 3 && num1done == 1)
            {
                num2 = 33;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 4 && num1done == 1)
            {
                num2 = 43;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 5 && num1done == 1)
            {
                num2 = 53;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 6 && num1done == 1)
            {
                num2 = 63;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 7 && num1done == 1)
            {
                num2 = 73;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 8 && num1done == 1)
            {
                num2 = 83;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 9 && num1done == 1)
            {
                num2 = 93;
                label1.Text = "" + num2;
            }
        }
        // "4" Button
        private void button4_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 4;
                label1.Text = "" + num1;
            }
            else if (num1 == 1 && num1done == 0)
            {
                num1 = 14;
                label1.Text = "" + num1;
            }
            else if (num1 == 2 && num1done == 0)
            {
                num1 = 24;
                label1.Text = "" + num1;
            }
            else if (num1 == 3 && num1done == 0)
            {
                num1 = 34;
                label1.Text = "" + num1;
            }
            else if (num1 == 4 && num1done == 0)
            {
                num1 = 44;
                label1.Text = "" + num1;
            }
            else if (num1 == 5 && num1done == 0)
            {
                num1 = 54;
                label1.Text = "" + num1;
            }
            else if (num1 == 6 && num1done == 0)
            {
                num1 = 64;
                label1.Text = "" + num1;
            }
            else if (num1 == 7 && num1done == 0)
            {
                num1 = 74;
                label1.Text = "" + num1;
            }
            else if (num1 == 8 && num1done == 0)
            {
                num1 = 84;
                label1.Text = "" + num1;
            }
            else if (num1 == 9 && num1done == 0)
            {
                num1 = 94;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0 && num1done == 1)
            {
                num2 = 4;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 1 && num1done == 1)
            {
                num2 = 14;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 2 && num1done == 1)
            {
                num2 = 24;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 3 && num1done == 1)
            {
                num2 = 34;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 4 && num1done == 1)
            {
                num2 = 44;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 5 && num1done == 1)
            {
                num2 = 54;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 6 && num1done == 1)
            {
                num2 = 64;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 7 && num1done == 1)
            {
                num2 = 74;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 8 && num1done == 1)
            {
                num2 = 84;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 9 && num1done == 1)
            {
                num2 = 94;
                label1.Text = "" + num2;
            }
        }
        // "5" Button
        private void button5_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 5;
                label1.Text = "" + num1;
            }
            else if (num1 == 1 && num1done == 0)
            {
                num1 = 15;
                label1.Text = "" + num1;
            }
            else if (num1 == 2 && num1done == 0)
            {
                num1 = 25;
                label1.Text = "" + num1;
            }
            else if (num1 == 3 && num1done == 0)
            {
                num1 = 35;
                label1.Text = "" + num1;
            }
            else if (num1 == 4 && num1done == 0)
            {
                num1 = 45;
                label1.Text = "" + num1;
            }
            else if (num1 == 5 && num1done == 0)
            {
                num1 = 55;
                label1.Text = "" + num1;
            }
            else if (num1 == 6 && num1done == 0)
            {
                num1 = 65;
                label1.Text = "" + num1;
            }
            else if (num1 == 7 && num1done == 0)
            {
                num1 = 75;
                label1.Text = "" + num1;
            }
            else if (num1 == 8 && num1done == 0)
            {
                num1 = 85;
                label1.Text = "" + num1;
            }
            else if (num1 == 9 && num1done == 0)
            {
                num1 = 95;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0 && num1done == 1)
            {
                num2 = 5;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 1 && num1done == 1)
            {
                num2 = 15;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 2 && num1done == 1)
            {
                num2 = 25;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 3 && num1done == 1)
            {
                num2 = 35;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 4 && num1done == 1)
            {
                num2 = 45;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 5 && num1done == 1)
            {
                num2 = 55;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 6 && num1done == 1)
            {
                num2 = 65;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 7 && num1done == 1)
            {
                num2 = 75;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 8 && num1done == 1)
            {
                num2 = 85;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 9 && num1done == 1)
            {
                num2 = 95;
                label1.Text = "" + num2;
            }
        }
        // "6" Button
        private void button6_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 6;
                label1.Text = "" + num1;
            }
            else if (num1 == 1 && num1done == 0)
            {
                num1 = 16;
                label1.Text = "" + num1;
            }
            else if (num1 == 2 && num1done == 0)
            {
                num1 = 26;
                label1.Text = "" + num1;
            }
            else if (num1 == 3 && num1done == 0)
            {
                num1 = 36;
                label1.Text = "" + num1;
            }
            else if (num1 == 4 && num1done == 0)
            {
                num1 = 46;
                label1.Text = "" + num1;
            }
            else if (num1 == 5 && num1done == 0)
            {
                num1 = 56;
                label1.Text = "" + num1;
            }
            else if (num1 == 6 && num1done == 0)
            {
                num1 = 66;
                label1.Text = "" + num1;
            }
            else if (num1 == 7 && num1done == 0)
            {
                num1 = 76;
                label1.Text = "" + num1;
            }
            else if (num1 == 8 && num1done == 0)
            {
                num1 = 86;
                label1.Text = "" + num1;
            }
            else if (num1 == 9 && num1done == 0)
            {
                num1 = 96;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0 && num1done == 1)
            {
                num2 = 6;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 1 && num1done == 1)
            {
                num2 = 16;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 2 && num1done == 1)
            {
                num2 = 26;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 3 && num1done == 1)
            {
                num2 = 36;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 4 && num1done == 1)
            {
                num2 = 46;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 5 && num1done == 1)
            {
                num2 = 56;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 6 && num1done == 1)
            {
                num2 = 66;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 7 && num1done == 1)
            {
                num2 = 76;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 8 && num1done == 1)
            {
                num2 = 86;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 9 && num1done == 1)
            {
                num2 = 96;
                label1.Text = "" + num2;
            }
        }
        // "7" Button
        private void button7_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 7;
                label1.Text = "" + num1;
            }
            else if (num1 == 1 && num1done == 0)
            {
                num1 = 17;
                label1.Text = "" + num1;
            }
            else if (num1 == 2 && num1done == 0)
            {
                num1 = 27;
                label1.Text = "" + num1;
            }
            else if (num1 == 3 && num1done == 0)
            {
                num1 = 37;
                label1.Text = "" + num1;
            }
            else if (num1 == 4 && num1done == 0)
            {
                num1 = 47;
                label1.Text = "" + num1;
            }
            else if (num1 == 5 && num1done == 0)
            {
                num1 = 57;
                label1.Text = "" + num1;
            }
            else if (num1 == 6 && num1done == 0)
            {
                num1 = 67;
                label1.Text = "" + num1;
            }
            else if (num1 == 7 && num1done == 0)
            {
                num1 = 77;
                label1.Text = "" + num1;
            }
            else if (num1 == 8 && num1done == 0)
            {
                num1 = 87;
                label1.Text = "" + num1;
            }
            else if (num1 == 9 && num1done == 0)
            {
                num1 = 97;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0 && num1done == 1)
            {
                num2 = 7;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 1 && num1done == 1)
            {
                num2 = 17;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 2 && num1done == 1)
            {
                num2 = 27;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 3 && num1done == 1)
            {
                num2 = 37;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 4 && num1done == 1)
            {
                num2 = 47;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 5 && num1done == 1)
            {
                num2 = 57;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 6 && num1done == 1)
            {
                num2 = 67;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 7 && num1done == 1)
            {
                num2 = 77;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 8 && num1done == 1)
            {
                num2 = 87;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 9 && num1done == 1)
            {
                num2 = 97;
                label1.Text = "" + num2;
            }
        }
        // "8" Button
        private void button8_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 8;
                label1.Text = "" + num1;
            }
            else if (num1 == 1 && num1done == 0)
            {
                num1 = 18;
                label1.Text = "" + num1;
            }
            else if (num1 == 2 && num1done == 0)
            {
                num1 = 28;
                label1.Text = "" + num1;
            }
            else if (num1 == 3 && num1done == 0)
            {
                num1 = 38;
                label1.Text = "" + num1;
            }
            else if (num1 == 4 && num1done == 0)
            {
                num1 = 48;
                label1.Text = "" + num1;
            }
            else if (num1 == 5 && num1done == 0)
            {
                num1 = 58;
                label1.Text = "" + num1;
            }
            else if (num1 == 6 && num1done == 0)
            {
                num1 = 68;
                label1.Text = "" + num1;
            }
            else if (num1 == 7 && num1done == 0)
            {
                num1 = 78;
                label1.Text = "" + num1;
            }
            else if (num1 == 8 && num1done == 0)
            {
                num1 = 88;
                label1.Text = "" + num1;
            }
            else if (num1 == 9 && num1done == 0)
            {
                num1 = 98;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0 && num1done == 1)
            {
                num2 = 8;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 1 && num1done == 1)
            {
                num2 = 18;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 2 && num1done == 1)
            {
                num2 = 28;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 3 && num1done == 1)
            {
                num2 = 38;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 4 && num1done == 1)
            {
                num2 = 48;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 5 && num1done == 1)
            {
                num2 = 58;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 6 && num1done == 1)
            {
                num2 = 68;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 7 && num1done == 1)
            {
                num2 = 78;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 8 && num1done == 1)
            {
                num2 = 88;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 9 && num1done == 1)
            {
                num2 = 98;
                label1.Text = "" + num2;
            }
        }
        // "9" Button
        private void button9_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 9;
                label1.Text = "" + num1;
            }
            else if (num1 == 1 && num1done == 0)
            {
                num1 = 19;
                label1.Text = "" + num1;
            }
            else if (num1 == 2 && num1done == 0)
            {
                num1 = 29;
                label1.Text = "" + num1;
            }
            else if (num1 == 3 && num1done == 0)
            {
                num1 = 39;
                label1.Text = "" + num1;
            }
            else if (num1 == 4 && num1done == 0)
            {
                num1 = 49;
                label1.Text = "" + num1;
            }
            else if (num1 == 5 && num1done == 0)
            {
                num1 = 59;
                label1.Text = "" + num1;
            }
            else if (num1 == 6 && num1done == 0)
            {
                num1 = 69;
                label1.Text = "" + num1;
            }
            else if (num1 == 7 && num1done == 0)
            {
                num1 = 79;
                label1.Text = "" + num1;
            }
            else if (num1 == 8 && num1done == 0)
            {
                num1 = 89;
                label1.Text = "" + num1;
            }
            else if (num1 == 9 && num1done == 0)
            {
                num1 = 99;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 0 && num1done == 1)
            {
                num2 = 9;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 1 && num1done == 1)
            {
                num2 = 19;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 2 && num1done == 1)
            {
                num2 = 29;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 3 && num1done == 1)
            {
                num2 = 39;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 4 && num1done == 1)
            {
                num2 = 49;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 5 && num1done == 1)
            {
                num2 = 59;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 6 && num1done == 1)
            {
                num2 = 69;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 7 && num1done == 1)
            {
                num2 = 79;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 8 && num1done == 1)
            {
                num2 = 89;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 9 && num1done == 1)
            {
                num2 = 99;
                label1.Text = "" + num2;
            }
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
            if (num1 == 1 && num2 == 0 && num1done == 0)
            {
                num1 = 10;
                label1.Text = "" + num1;
            }
            else if (num1 == 2 && num2 == 0 && num1done == 0)
            {
                num1 = 20;
                label1.Text = "" + num1;
            }
            else if (num1 == 3 && num2 == 0 && num1done == 0)
            {
                num1 = 30;
                label1.Text = "" + num1;
            }
            else if (num1 == 4 && num2 == 0 && num1done == 0)
            {
                num1 = 40;
                label1.Text = "" + num1;
            }
            else if (num1 == 5 && num2 == 0 && num1done == 0)
            {
                num1 = 50;
                label1.Text = "" + num1;
            }
            else if (num1 == 6 && num2 == 0 && num1done == 0)
            {
                num1 = 60;
                label1.Text = "" + num1;
            }
            else if (num1 == 7 && num2 == 0 && num1done == 0)
            {
                num1 = 70;
                label1.Text = "" + num1;
            }
            else if (num1 == 8 && num2 == 0 && num1done == 0)
            {
                num1 = 80;
                label1.Text = "" + num1;
            }
            else if (num1 == 9 && num2 == 0 && num1done == 0)
            {
                num1 = 90;
                label1.Text = "" + num1;
            }
            else if (num1 == 10 && num2 == 0 && num1done == 0)
            {
                num1 = 100;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num2 == 1 && num1done == 1)
            {
                num2 = 10;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 2 && num1done == 1)
            {
                num2 = 20;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 3 && num1done == 1)
            {
                num2 = 30;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 4 && num1done == 1)
            {
                num2 = 40;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 5 && num1done == 1)
            {
                num2 = 50;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 6 && num1done == 1)
            {
                num2 = 60;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 7 && num1done == 1)
            {
                num2 = 70;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 8 && num1done == 1)
            {
                num2 = 80;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 9 && num1done == 1)
            {
                num2 = 90;
                label1.Text = "" + num2;
            }
            else if (num1 != 0 && num2 == 10 && num1done == 1)
            {
                num2 = 100;
                label1.Text = "" + num2;
            }
        }
    }
}
