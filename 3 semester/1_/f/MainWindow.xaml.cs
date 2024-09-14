using System.Security.Cryptography.X509Certificates;
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

namespace f
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string? action = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            action = "add";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            if (action != null & firstNumber.Text != null & secondNumber.Text != null)
            {
                double? result = null;
                switch (action)
                {
                    case "add":
                        result = double.Parse(firstNumber.Text) + double.Parse(secondNumber.Text);
                        break;
                    case "subtract":
                        result = double.Parse(firstNumber.Text) - double.Parse(secondNumber.Text);
                        break;
                    case "multiply":
                        result = double.Parse(firstNumber.Text) * double.Parse(secondNumber.Text);
                        break;
                    case "subdivide":
                        result = double.Parse(firstNumber.Text) / double.Parse(secondNumber.Text);
                        break;
                }
                answer.Text = result.ToString();
            }
            else 
            {
                //MessageBox.Show("Lūdzu ierakstiet skaitļus un izvēlieties darbību!");
                answer.Text = "Lūdzu ierakstiet skaitļus un izvēlieties darbību!";
            }

        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            action = "subtract";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            action = "multiply";
        }

        private void subdivide_Click(object sender, RoutedEventArgs e)
        {
            action = "subdivide";
        }

        private void firstNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Text == "Enter first number")
            {
                firstNumber.Text = "";
            }
            //else
            //{
            //    firstNumber.SelectAll();
            //}
        }

        private void secondNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (secondNumber.Text == "Enter second number")
            {
                secondNumber.Text = "";
            }
            //else
            //{
            //    secondNumber.SelectAll();
            //}
        }
    }
}