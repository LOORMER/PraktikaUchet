using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PrakrikaUP04._01.appData;
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
    /// Логика взаимодействия для ClasssPage.xaml
    /// </summary>
    public partial class ClasssPage : Page
    {
        public ClasssPage()
        {
            InitializeComponent();
            ClassDG.ItemsSource = Connect.context.Class.ToList();
        }
    }
}
