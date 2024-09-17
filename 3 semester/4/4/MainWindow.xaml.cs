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

namespace _4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cBaddElement_Click(object sender, RoutedEventArgs e)
        {
            string elementContent = CBElement.Text;
            if (string.IsNullOrEmpty(elementContent))
            {
                MessageBox.Show("Ievadiet elementa nosaukumu", "Nepareizi dati", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else {
                combobox.Items.Add(elementContent);
            }
        }

        private void LBaddElement_Click(object sender, RoutedEventArgs e)
        {
            string elementContent = LBElement.Text;
            if (string.IsNullOrEmpty(elementContent))
            {
                MessageBox.Show("Ievadiet elementa nosaukumu", "Nepareizi dati", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                listbox.Items.Add(elementContent);
            }
        }

        private void cBDeleteElement_Click(object sender, RoutedEventArgs e)
        {
            if (combobox.SelectedItem != null)
            {
                combobox.Items.Remove(combobox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Atlaisiet elementu", "Nepareizi dati", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void cBEditElement_Click(object sender, RoutedEventArgs e)
        {
            if (combobox.SelectedItem != null)
            {
                ComboBoxItem selectedItem = combobox.SelectedItem as ComboBoxItem;
                string elementContent = CBElement.Text;
                if (string.IsNullOrEmpty(elementContent))
                {
                    MessageBox.Show("Ievadiet elementa nosaukumu", "Nepareizi dati", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    selectedItem.Content = elementContent;
                    CBElement.Clear();
                }
            }
            else
            {
                MessageBox.Show("Atlaisiet elementu", "Nepareizi dati", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}