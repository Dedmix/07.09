using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp8.Pages
{
    /// <summary>
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        public Start()
        {
            InitializeComponent();
        }

        double a, b;
        int d;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button c = (Button)sender;
            if (Display.Text.Length == 1 && Display.Text == "0")
            {
                Display.Text = c.Content.ToString();
                if (Display.Text.Length == 1 && Display.Text == ",")
                {
                    Display.Text = c.Content.ToString();
                }
                else
                {
                    Display.Text += c.Content.ToString();
                }
            }
            else
            {
                Display.Text += c.Content.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Double x = Double.Parse(Display.Text);
            double l = (Math.Pow(x, 2));
            Display.Text = Convert.ToString(l);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            a = Double.Parse(Display.Text);
            Display.Clear();
            d = 1;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            a = Double.Parse(Display.Text);
            Display.Clear();
            d = 2;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            a = Double.Parse(Display.Text);
            Display.Clear();
            d = 3;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            a = Double.Parse(Display.Text);
            Display.Clear();
            d = 4;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            b = Convert.ToDouble(Display.Text);
            if (d == 1)
            {
                Display.Text = Convert.ToString(a + b);
            }
            if (d == 2)
            {
                Display.Text = Convert.ToString(a - b);
            }
            if (d == 3)
            {
                Display.Text = Convert.ToString(a * b);
            }
            if (d == 4)
            {
                Display.Text = Convert.ToString(a / b);
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string p = Display.Text;
            p = p.Remove(p.Length - 1);
            Display.Text = p;
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Class1.PageLogin);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Display.Text = Display.Text + ",";
        }
    }
}
