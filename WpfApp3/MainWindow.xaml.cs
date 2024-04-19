using System.Data;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string text;
        string cpy;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            text = text.Substring(0, text.Length - 1);
            label.Content = text;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            text += "1";

            label.Content = text;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            text += "2";

            label.Content = text;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            text += "3";
            label.Content = text;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            text += "4";
            label.Content = text;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            text += "5";
            label.Content = text;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            text += "6";
            label.Content = text;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            text += "7";
            label.Content = text;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            text += "8";
            label.Content = text;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            text += "9";
            label.Content = text;
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            text += "0";
            label.Content = text;
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            text = string.Empty;
            label.Content = text;
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            text = string.Empty;
            label.Content = text;
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            text += "+";
            cpy += text;
            text = string.Empty;
            label.Content = text;
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            text += "-";
            cpy += text;
            text = string.Empty;
            label.Content = text;
        }

        private void ButtonMultiple_Click(object sender, RoutedEventArgs e)
        {
            text += "*";
            cpy += text;
            text = string.Empty;
            label.Content = text;
        }

        private void ButtonBolme_Click(object sender, RoutedEventArgs e)
        {
            text += "/";
            cpy += text;
            text = string.Empty;
            label.Content = text;
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            cpy += text;
            DataTable table = new DataTable();
            double result = Convert.ToDouble(table.Compute(cpy, ""));
            label.Content = result.ToString();
            text = string.Empty;
            cpy = string.Empty;
        }

    }
}
