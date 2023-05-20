using Algorithm.ViewModel;
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

namespace Algorithm.View
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public DataManageProfile context = new DataManageProfile();
        public Profile()
        {
            InitializeComponent();
            this.DataContext = context;
        }

        private void Question_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Question.Text.Length > 0)
            {
                QuestionPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                QuestionPlug.Visibility = Visibility.Visible;
            }
        }

    }
}
