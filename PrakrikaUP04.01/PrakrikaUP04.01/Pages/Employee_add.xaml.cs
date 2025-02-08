using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using PrakrikaUP04._01.appData;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrakrikaUP04._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для Employee_add.xaml
    /// </summary>
    public partial class Employee_add : Page
    {
        Employee em;
        bool chek;
        public Employee_add(Employee employee)
        {
            InitializeComponent();
            em = employee;
            if (em == null)
            {
                em = new Employee();
                chek = true;
            }
            else chek = false;
            DataContext = em;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (chek)
            {
                Connect.context.Employee.Add(em); 
            }
            Connect.context.SaveChanges();
            Nav.MainFrame.GoBack();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
    }
}
