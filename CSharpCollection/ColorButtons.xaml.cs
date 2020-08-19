using System;
using System.Collections.Generic;
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
    /// Interaction logic for ColorButtons.xaml
    /// </summary>
    public partial class ColorButtons : Page
    {
        public int clickcount;

        public ColorButtons()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MainMenu page = new MainMenu();
            NavigationService.Navigate(page);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            clickcount = clickcount + 1;
            label1.Content = "You've clicked " + clickcount + " time(s)!";
            textBlock1.Background = Brushes.Red;
            label2.Content = "Red";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            clickcount = clickcount + 1;
            label1.Content = "You've clicked " + clickcount + " time(s)!";
            textBlock1.Background = Brushes.Orange;
            label2.Content = "Orange";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            clickcount = clickcount + 1;
            label1.Content = "You've clicked " + clickcount + " time(s)!";
            textBlock1.Background = Brushes.Yellow;
            label2.Content = "Yellow";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            clickcount = clickcount + 1;
            label1.Content = "You've clicked " + clickcount + " time(s)!";
            textBlock1.Background = Brushes.LightGreen;
            label2.Content = "Green";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            clickcount = clickcount + 1;
            label1.Content = "You've clicked " + clickcount + " time(s)!";
            textBlock1.Background = Brushes.Blue;
            label2.Content = "Blue";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            clickcount = clickcount + 1;
            label1.Content = "You've clicked " + clickcount + " time(s)!";
            textBlock1.Background = Brushes.Purple;
            label2.Content = "Purple";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            clickcount = 0;
            label1.Content = "You've clicked " + clickcount + " time(s)!";
            textBlock1.Background = Brushes.Black;
            label2.Content = "Black";
        }
    }
}
