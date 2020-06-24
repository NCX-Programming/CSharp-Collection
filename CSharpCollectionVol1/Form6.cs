using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSharpCollectionVol1
{
    public partial class Form6 : Form
    {

        public string notes1;
        public string notes2;
        public string notes3;
        public string notes4;
        public string notes5;
        public string save;

        static readonly string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true;
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            if (save == "Save 1")
            {
                notes1 = textBox1.Text;
                TextWriter tw = new StreamWriter(Path.Combine(SavePath,"notes1.txt"));
                tw.WriteLine(notes1);
                tw.Close();
            }
            else if (save == "Save 2")
            {
                notes2 = textBox1.Text;
                TextWriter tw = new StreamWriter(Path.Combine(SavePath, "notes2.txt"));
                tw.WriteLine(notes2);
                tw.Close();
            }
            else if (save == "Save 3")
            {
                notes3 = textBox1.Text;
                TextWriter tw = new StreamWriter(Path.Combine(SavePath, "notes3.txt"));
                tw.WriteLine(notes3);
                tw.Close();
            }
            else if (save == "Save 4")
            {
                notes4 = textBox1.Text;
                TextWriter tw = new StreamWriter(Path.Combine(SavePath, "notes4.txt"));
                tw.WriteLine(notes4);
                tw.Close();
            }
            else if (save == "Save 5")
            {
                notes5 = textBox1.Text;
                TextWriter tw = new StreamWriter(Path.Combine(SavePath, "notes4.txt"));
                tw.WriteLine(notes5);
                tw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (save == "Save 1")
            {
                TextReader tr = new StreamReader(Path.Combine(SavePath,"notes1.txt"));
                string notes1string = tr.ReadLine();
                notes1 = Convert.ToString(notes1string);
                tr.Close();
                textBox1.Text = notes1string;
            }
            else if (save == "Save 2")
            {
                TextReader tr = new StreamReader(Path.Combine(SavePath, "notes2.txt"));
                string notes2string = tr.ReadLine();
                notes1 = Convert.ToString(notes2string);
                tr.Close();
                textBox1.Text = notes2string;
            }
            else if (save == "Save 3")
            {
                TextReader tr = new StreamReader(Path.Combine(SavePath, "notes3.txt"));
                string notes3string = tr.ReadLine();
                notes1 = Convert.ToString(notes3string);
                tr.Close();
                textBox1.Text = notes3string;
            }
            else if (save == "Save 4")
            {
                TextReader tr = new StreamReader(Path.Combine(SavePath, "notes4.txt"));
                string notes4string = tr.ReadLine();
                notes1 = Convert.ToString(notes4string);
                tr.Close();
                textBox1.Text = notes4string;
            }
            else if (save == "Save 5")
            {
                TextReader tr = new StreamReader(Path.Combine(SavePath, "notes5.txt"));
                string notes5string = tr.ReadLine();
                notes1 = Convert.ToString(notes5string);
                tr.Close();
                textBox1.Text = notes5string;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            save = (string)comboBox1.SelectedItem;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
