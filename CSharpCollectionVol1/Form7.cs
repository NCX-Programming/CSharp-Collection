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
        public string engine;
        
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
            switch (engine)
            {
                case "Google":
                    SearchTerms = textBox1.Text;
                    SearchTerms = SearchTerms.Replace(" ", "+");
                    link = "https://www.google.com/search?client=firefox-b-1-d&q=" + SearchTerms;
                    System.Diagnostics.Process.Start(link);
                    break;
                case "Bing":
                    SearchTerms = textBox1.Text;
                    SearchTerms = SearchTerms.Replace(" ", "+");
                    link = "https://www.bing.com/search?q=" + SearchTerms;
                    System.Diagnostics.Process.Start(link);
                    break;
                case "DuckDuckGo":
                    SearchTerms = textBox1.Text;
                    SearchTerms = SearchTerms.Replace(" ", "+");
                    link = "https://duckduckgo.com/?q=" + SearchTerms;
                    System.Diagnostics.Process.Start(link);
                    break;
                case "AOL":
                    SearchTerms = textBox1.Text;
                    SearchTerms = SearchTerms.Replace(" ", "+");
                    link = "https://search.aol.com/aol/search?q=" + SearchTerms;
                    System.Diagnostics.Process.Start(link);
                    break;
                case "All":
                    SearchTerms = textBox1.Text;
                    SearchTerms = SearchTerms.Replace(" ", "+");
                    link = "https://search.aol.com/aol/search?q=" + SearchTerms;
                    System.Diagnostics.Process.Start(link);
                    link = "https://duckduckgo.com/?q=" + SearchTerms;
                    System.Diagnostics.Process.Start(link);
                    link = "https://www.bing.com/search?q=" + SearchTerms;
                    System.Diagnostics.Process.Start(link);
                    link = "https://www.google.com/search?client=firefox-b-1-d&q=" + SearchTerms;
                    System.Diagnostics.Process.Start(link);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            engine = (string)comboBox1.SelectedItem;
        }
    }
}
