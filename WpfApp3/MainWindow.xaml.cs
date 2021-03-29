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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtEdito_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("О разработчике");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("О разработчике");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            X.Background = Brushes.Red;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            X.Background = Brushes.Green;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            X.Background = Brushes.Blue;
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            X.Background = Brushes.Red;
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            X.Background = Brushes.Green;
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            X.Background = Brushes.Blue;
        }
    }
}
