using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
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
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Page
    {
        public About()
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
            string url = "https://github.com/NinjaCheetah/CSharpCollectionVol1";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
