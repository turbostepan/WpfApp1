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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void but12_Click(object sender, RoutedEventArgs e)
        
            if (DataTable_dt_Table = MainWindow.Select("SELECT * FROM [dbo].[Table] WHERE [data] = '" + textBox_data.Text + "' AND [TableN] = '" + ComboBox_CB.Text)
        {
            MessageBox.Show("Столик успешно забронирован!");
            NavigationService.Navigate(new Page1());
        }
    else MessageBox.Show("Упс! скорее всего столик уже заняли, попробуйте еще раз.");
            NavigationService.Navigate(new Page1());

             
    }
}
