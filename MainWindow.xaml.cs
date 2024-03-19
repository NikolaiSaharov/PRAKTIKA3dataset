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
using PRAKTIKA3.DataSet1TableAdapters;
namespace PRAKTIKA3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PassengersTableAdapter passengers= new PassengersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            TicketGrid.ItemsSource = passengers.GetDataBy();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TicketGrid.Columns[0].Visibility = Visibility.Collapsed;
            TicketGrid.Columns[5].Visibility = Visibility.Collapsed;
        }
    }
}
