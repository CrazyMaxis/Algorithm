using Algorithm.ViewModel.admin;
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
    /// <summary>
    /// Логика взаимодействия для AddCourse.xaml
    /// </summary>
    public partial class AddCourse : Window
    {
        public AddCourse(DataManageCoursesAdmin context)
        {
            InitializeComponent();
            this.DataContext = context;
        }

        private void ElementPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ElementPrice.Text.Length > 0)
            {
                ElementPricePlug.Visibility = Visibility.Hidden;
            }
            else
            {
                ElementPricePlug.Visibility = Visibility.Visible;
            }
        }

        private void ElementDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ElementDescription.Text.Length > 0)
            {
                ElementDescriptionPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                ElementDescriptionPlug.Visibility = Visibility.Visible;
            }
        }

        private void ElementName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ElementName.Text.Length > 0)
            {
                ElementNamePlug.Visibility = Visibility.Hidden;
            }
            else
            {
                ElementNamePlug.Visibility = Visibility.Visible;
            }
        }
    }
}
