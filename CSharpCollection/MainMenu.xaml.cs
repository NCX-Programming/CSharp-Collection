﻿using System;
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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            About page = new About();
            NavigationService.Navigate(page);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            ColorButtons page = new ColorButtons();
            NavigationService.Navigate(page);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            CSharpCalc page = new CSharpCalc();
            NavigationService.Navigate(page);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string message = "I've decided to postpone Tic Tac No until v2.8 so I could work more on win conditions. Don't worry, it shouldn't be too long until it releases!";
            string caption = "Returning in v2.8";
            MessageBoxButton buttons = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.OK)
            {

            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            string message = "Due to some differences between .NET Framework and .NET Core, C#Notes is going to take more work to get working. Stay tuned, because it will return!";
            string caption = "Coming (back) soon!";
            MessageBoxButton buttons = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.OK)
            {

            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            CSharpSearch page = new CSharpSearch();
            NavigationService.Navigate(page);
        }
    }
}
