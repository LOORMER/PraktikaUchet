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
    /// Логика взаимодействия для SubjectAdd.xaml
    /// </summary>
    public partial class SubjectAdd : Page
    {
        Subject su;
        bool chek;

        public SubjectAdd(Subject subject)
        {
            InitializeComponent();
            su = subject;
            if (su == null)
            {
                su = new Subject();
                chek = true;
            }
            else chek = false;
            DataContext = su;
           
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (chek)
            {
                Connect.context.Subject.Add(su);
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
