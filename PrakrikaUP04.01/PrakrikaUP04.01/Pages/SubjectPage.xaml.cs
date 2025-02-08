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
using PrakrikaUP04._01.appData;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrakrikaUP04._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для SubjectPage.xaml
    /// </summary>
    public partial class SubjectPage : Page
    {
        public SubjectPage()
        {
            InitializeComponent();
            SubjectDG.ItemsSource = Connect.context.Subject.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SubjectDG.ItemsSource = Connect.context.Subject.ToList();
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new SubjectAdd(null));
        }
    }
}
