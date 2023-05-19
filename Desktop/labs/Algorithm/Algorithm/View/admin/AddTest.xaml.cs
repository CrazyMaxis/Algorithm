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
using Algorithm.ViewModel.admin;

namespace Algorithm.View.admin
{

    public partial class AddTest : Window
    {
        public AddTest(DataManageTestsAdmin context)
        {
            InitializeComponent();
            this.DataContext = context;
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

        private void ElementLevel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ElementLevel.Text.Length > 0)
            {
                ElementLevelPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                ElementLevelPlug.Visibility = Visibility.Visible;
            }
        }

        private void ElementSource_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ElementSource.Text.Length > 0)
            {
                ElementSourcePlug.Visibility = Visibility.Hidden;
            }
            else
            {
                ElementSourcePlug.Visibility = Visibility.Visible;
            }
        }
    }
}
