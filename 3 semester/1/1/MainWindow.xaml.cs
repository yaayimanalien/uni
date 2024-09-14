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

namespace _1
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            action = "add";
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

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            if (action == null)
            {
                MessageBox.Show("Lūdzu izvēlies darbību!");
            }
            else
            {
                if (firstNumber==null | secondNumber==null)
                {
                    MessageBox.Show("Lūdzu ierakstiet skaitļus!");
                }
                else
                {
                    bool a;
                    bool b;
                    int rand = int.TryParse(firstNumber.Text, out a);

                    if ()
                    {
                        switch (action)
                        {
                            case "sum":
                                answer.Text = (double.Parse(firstNumber.Text) + double.Parse(secondNumber.Text)).ToString();
                                break;
                            case "subtract":
                                answer.Text = (double.Parse(firstNumber.Text) - double.Parse(secondNumber.Text)).ToString();
                                break;
                            case "multiply":
                                answer.Text = (double.Parse(firstNumber.Text) * double.Parse(secondNumber.Text)).ToString();
                                break;
                            case "divide":
                                answer.Text = (double.Parse(firstNumber.Text) / double.Parse(secondNumber.Text)).ToString();
                                break;
                        }
                    }
                }
            }
        }
    }
}