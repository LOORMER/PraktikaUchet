using PrakrikaUP04._01.appData;
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

namespace PrakrikaUP04._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClassBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new ClasssPage());
        }

        private void EmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new EmployeePage());
        }

        private void Payment_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new PaymentPage());
        }

        private void Position_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new PositionPage());
        }

        private void SubjectBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new SubjectPage());
        }
    }
}
