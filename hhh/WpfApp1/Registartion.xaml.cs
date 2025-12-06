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
    /// Логика взаимодействия для Registartion.xaml
    /// </summary>
    public partial class Registrartion : Window
    {
        public Registrartion()
        {
            InitializeComponent();
        }

        private void txtLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Registration2 registrartion2 = new Registration2();
            registrartion2.Show();
            Close();
        }

        private void btnLogin_Копировать_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Close();
        }
    }
}
