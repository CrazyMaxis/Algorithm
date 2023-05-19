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
using Algorithm.View;

namespace Algorithm.View
{
    public partial class Home : Page
    {
        MainUser mf;
        Catalog catalog = new Catalog();
        public Home(MainUser main)
        {
            InitializeComponent();
            mf = main;
        }
        private void LetsGo_Click(object sender, RoutedEventArgs e)
        {
            mf.MainFrame.Navigate(catalog);
        }
    }
}
