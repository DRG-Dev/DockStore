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
using DokStore.Pages;

namespace DokStore
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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            const string message =
        "Вы уверены что хотите закрыть окно?";
            const string caption = "Выход из приложения";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {

                this.Close();
            }
        }

        private void ButtonAuth_Click_1(object sender, RoutedEventArgs e)
        {
            Farme.NavigationService.Navigate(new Uri("Pages/AvtorizPage.xaml", UriKind.Relative));
            Farme.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Farme.NavigationService.Navigate(new Uri("Pages/RegPage.xaml", UriKind.Relative));
            Farme.Visibility = Visibility.Visible;
        }

        private void ButtonMain_Click(object sender, RoutedEventArgs e)
        {
            Farme.Visibility = Visibility.Hidden;
        }
    }
}
