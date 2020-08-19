using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
    /// Interaction logic for CSharpCalc.xaml
    /// </summary>
    public partial class CSharpCalc : Page
    {
        public decimal num1;
        public decimal num2;
        public int opr;
        public decimal ans;
        public int num1done;

        void doButton(int button)
        {
            // Function for button pushes. Format: "doButton(<number on buton>)"
            // Uses a try/catch system to avoid overflow errors when inputting numbers
            if (num1 == 0 && num1done == 0)
            {
                num1 = button;
                label1.Text = "" + num1;
            }
            else if (num1 != 0 && num1done == 0)
            {
                try
                {
                    num1 = (num1 * 10) + button;
                    label1.Text = "" + num1;
                }
                catch (OverflowException)
                {
                    string message = "You have exceeded the maximum length of a decimal.";
                    string caption = "Overflow Error";
                    MessageBoxButton buttons = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Error;
                    if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.OK)
                    {
                        num1 = 0;
                        num2 = 0;
                        ans = 0;
                        opr = 0;
                        label1.Text = "0";
                        num1done = 0;
                    }
                }
            }
            else if (num2 == 0 && num1done == 1)
            {
                num2 = button;
                label1.Text = "" + num2;
            }
            else if (num2 != 0 && num1done == 1)
            {
                try
                {
                    num2 = (num2 * 10) + button;
                    label1.Text = "" + num2;
                }
                catch (OverflowException)
                {
                    string message = "You have exceeded the maximum length of a decimal.";
                    string caption = "Overflow Error";
                    MessageBoxButton buttons = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Error;
                    if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.OK)
                    {
                        num1 = 0;
                        num2 = 0;
                        ans = 0;
                        opr = 0;
                        label1.Text = "0";
                        num1done = 0;
                    }
                }
            }
        }

        public CSharpCalc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Return to menu
            MainMenu page = new MainMenu();
            NavigationService.Navigate(page);
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            // Event triggered when the equals button is pressed
            // Uses the same try/catch system as the button push function to avoid overflow errors when adding and multiplying
            if (num1 != 0 && num2 != 0 && opr == 1 && num1done == 1)
            {
                try
                {
                    ans = num1 + num2;
                    label1.Text = "" + ans;
                }
                catch (OverflowException)
                {
                    string message = "You have exceeded the maximum length of a decimal.";
                    string caption = "Overflow Error";
                    MessageBoxButton buttons = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Error;
                    if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.OK)
                    {
                        num1 = 0;
                        num2 = 0;
                        ans = 0;
                        opr = 0;
                        label1.Text = "0";
                        num1done = 0;
                    }
                }
            }
            else if (num1 != 0 && num2 != 0 && opr == 2 && num1done == 1)
            {
                ans = num1 - num2;
                label1.Text = "" + ans;
            }
            else if (num1 != 0 && num2 != 0 && opr == 3 && num1done == 1)
            {
                try
                {
                    ans = num1 * num2;
                    label1.Text = "" + ans;
                }
                catch (OverflowException)
                {
                    string message = "You have exceeded the maximum length of a decimal.";
                    string caption = "Overflow Error";
                    MessageBoxButton buttons = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Error;
                    if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.OK)
                    {
                        num1 = 0;
                        num2 = 0;
                        ans = 0;
                        opr = 0;
                        label1.Text = "0";
                        num1done = 0;
                    }
                }
            }
            else if (num1 != 0 && num2 != 0 && opr == 4 && num1done == 1)
            {
                ans = num1 / num2;
                label1.Text = "" + ans;
            }
        }

        private void Button45345_Click(object sender, RoutedEventArgs e)
        {
            // Clear button. Resets all variables and the label
            num1 = 0;
            num2 = 0;
            ans = 0;
            opr = 0;
            label1.Text = "0";
            num1done = 0;
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            // Event for "+" button
            opr = 1;
            num1done = 1;
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            // Event for "-" button
            opr = 2;
            num1done = 1;
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            // Event for "*" button
            opr = 3;
            num1done = 1;
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            // Event for "/" button
            opr = 4;
            num1done = 1;
        }

        // Next section just has the function triggers for the number buttons
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            doButton(1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            doButton(2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            doButton(3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            doButton(4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            doButton(5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            doButton(6);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            doButton(7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            doButton(8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            doButton(9);
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            // 0 button event
            // Yet again uses try/catch to avoid overflow exceptions
            if (num1 != 0 && num1done == 0)
            {
                try
                {
                    num1 = num1 * 10;
                    label1.Text = "" + num1;
                }
                catch (OverflowException)
                {
                    string message = "You have exceeded the maximum length of a decimal.";
                    string caption = "Overflow Error";
                    MessageBoxButton buttons = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Error;
                    if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.OK)
                    {
                        num1 = 0;
                        num2 = 0;
                        ans = 0;
                        opr = 0;
                        label1.Text = "0";
                        num1done = 0;
                    }
                }
            }
            else if (num2 != 0 && num1done == 1)
            {
                try
                {
                    num2 = num2 * 10;
                    label1.Text = "" + num2;
                }
                catch (OverflowException)
                {
                    string message = "You have exceeded the maximum length of a decimal.";
                    string caption = "Overflow Error";
                    MessageBoxButton buttons = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Error;
                    if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.OK)
                    {
                        num1 = 0;
                        num2 = 0;
                        ans = 0;
                        opr = 0;
                        label1.Text = "0";
                        num1done = 0;
                    }
                }
            }
        }
    }
}
