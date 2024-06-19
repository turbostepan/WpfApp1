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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void enter_Clik(object sender, RoutedEventArgs e)
        {
            if (TextBox_number.Length < 10 || > 10)
            {
                MessageBox.Show("Номер не существует!");
            }

            if (TextBox_data.Length < 0)
            {
                MessageBox.Show("Вы не указали дату");
            }

            if (TextBox_g.Length < 1 || > 4)
            {
                MessageBox.Show("У нас нет таких столиков, введите число от 1 до 4");
            }

            else {
            }
            private void but11_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new Page4());
            }
        }

    }
}
