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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();
        }
        
        private void Qutton_Click(object sender, RoutedEventArgs e)
        {
            Catalog registrartion = new Catalog();
            registrartion.Show();
            Close();
        }
        private void Futton_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            order.Show();
            Close();
        }
        private void Dutton_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            Close();
        }
        private void Lutton_Click(object sender, RoutedEventArgs e)
        {
            Basket basket = new Basket();
            basket.Show();
            Close();
        }
        private void Putton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Wutton_Click(object sender, RoutedEventArgs e)
        {
            Help help = new Help();
            help.Show();
            Close();
        }
        private void Vutton_Click(object sender, RoutedEventArgs e)
        {
            MainL mainL = new MainL();
            mainL.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Autton_Click(object sender, RoutedEventArgs e)
        {
            Notification notification = new Notification();
            notification.Show();
            Close();
        }
        private void Zutton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Uutton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Catalog registrartion = new Catalog();
            registrartion.Show();
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
