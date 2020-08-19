using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpCollection
{
    /// <summary>
    /// Interaction logic for CSharpSearch.xaml
    /// </summary>
    public partial class CSharpSearch : Page
    {
        public string SearchTerms;
        public string link;
        public string engine;

        public CSharpSearch()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu page = new MainMenu();
            NavigationService.Navigate(page);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (radioBtn1.IsChecked == true)
            {
                engine = "All";
            }
            else if (radioBtn2.IsChecked == true)
            {
                engine = "Google";
            }
            else if (radioBtn3.IsChecked == true)
            {
                engine = "Bing";
            }
            else if (radioBtn4.IsChecked == true)
            {
                engine = "Yahoo";
            }
            else if (radioBtn5.IsChecked == true)
            {
                engine = "AOL";
            }
            else if (radioBtn6.IsChecked == true)
            {
                engine = "DuckDuckGo";
            }
            switch (engine)
            {
                case "Google":
                    SearchTerms = textBox1.Text;
                    SearchTerms = SearchTerms.Replace(" ", "+");
                    link = "https://www.google.com/search?client=firefox-b-1-d&q=" + SearchTerms;
                    Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
                    break;
                case "Bing":
                    SearchTerms = textBox1.Text;
                    SearchTerms = SearchTerms.Replace(" ", "+");
                    link = "https://www.bing.com/search?q=" + SearchTerms;
                    Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
                    break;
                case "DuckDuckGo":
                    SearchTerms = textBox1.Text;
                    SearchTerms = SearchTerms.Replace(" ", "+");
                    link = "https://duckduckgo.com/?q=" + SearchTerms;
                    Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
                    break;
                case "AOL":
                    SearchTerms = textBox1.Text;
                    SearchTerms = SearchTerms.Replace(" ", "+");
                    link = "https://search.aol.com/aol/search?q=" + SearchTerms;
                    Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
                    break;
                case "Yahoo":
                    SearchTerms = textBox1.Text;
                    SearchTerms = SearchTerms.Replace(" ", "+");
                    link = "https://search.yahoo.com/search?p=" + SearchTerms;
                    Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
                    break;
                case "All":
                    SearchTerms = textBox1.Text;
                    SearchTerms = SearchTerms.Replace(" ", "+");
                    link = "https://search.aol.com/aol/search?q=" + SearchTerms;
                    Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
                    link = "https://duckduckgo.com/?q=" + SearchTerms;
                    Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
                    link = "https://www.bing.com/search?q=" + SearchTerms;
                    Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
                    link = "https://www.google.com/search?client=firefox-b-1-d&q=" + SearchTerms;
                    Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
                    link = "https://search.yahoo.com/search?p=" + SearchTerms;
                    Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
                    break;
                default:
                    string message = "You need to specify a search engine first!";
                    string caption = "No Engine Selected";
                    MessageBoxButton buttons = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Exclamation;
                    if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.OK)
                    {

                    }
                    break;
            }
        }
    }
}
