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
    public partial class AnswerAdmin : Window
    {
        public AnswerAdmin(DataManageQuestionAdmin context)
        {
            InitializeComponent();
            this.DataContext = context;
        }

        private void Answer_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Answer.Text.Length > 0)
            {
                AnswerPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                AnswerPlug.Visibility = Visibility.Visible;
            }
        }
    }
}
