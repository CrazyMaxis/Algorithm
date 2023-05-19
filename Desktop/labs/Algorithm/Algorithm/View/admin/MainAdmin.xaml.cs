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
using System.Windows.Shapes;

namespace Algorithm.View.admin
{
    public partial class MainAdmin : Window
    {
        CatalogAdmin catalog = new CatalogAdmin();
        TestsAdmin testAdmin = new TestsAdmin();
        CoursesAdmin courseAdmin = new CoursesAdmin();
        public MainAdmin()
        {
            InitializeComponent();
            MainFrame.Navigate(catalog);
        }

        private void Home_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Catalog_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(catalog);
        }

        private void Tests_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(testAdmin);
        }

        private void Courses_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(courseAdmin);
        }

        private void UserTests_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Questions_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
