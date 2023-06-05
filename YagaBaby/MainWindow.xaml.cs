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

namespace YagaBaby
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

        private void info(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new info());
        }

        private void siz(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new siz());
        }

        private void DangerZone(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new dangerzone());
        }

        private void details(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new details());
        }

        private void size(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new size());
        }

        private void filter(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new filter());
        }

        private void control(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new control());
        }

        private void qrcode(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new qr());
        }

        private void dozo(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
