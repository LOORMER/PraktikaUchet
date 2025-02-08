using PrakrikaUP04._01.appData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        public EmployeePage()
        {
            InitializeComponent();
            EmployeeDG.ItemsSource = Connect.context.Employee.ToList();
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Employee_add(null));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeeDG.ItemsSource = Connect.context.Employee.ToList();
        }
    }
}
