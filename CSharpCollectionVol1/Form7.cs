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
    public partial class Form7 : Form
    {
        public string SearchTerms;
        public string link;
        
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true;
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchTerms = textBox1.Text;
            link = "https://www.google.com/search?client=firefox-b-1-d&q=" + SearchTerms;
            System.Diagnostics.Process.Start(link);
        }
    }
}
