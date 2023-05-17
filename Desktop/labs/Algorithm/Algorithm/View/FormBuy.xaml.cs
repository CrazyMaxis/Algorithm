using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Algorithm.ViewModel;

namespace Algorithm.View
{
    public partial class FormBuy : Window
    {
        public int course_id;
        public FormBuy(int course_id)
        {
            InitializeComponent();
            this.course_id = course_id;
            this.DataContext = new DataManageCourses();
        }

        private void CardNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CardNumber.Text.Length > 0)
            {
                CardNumberPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                CardNumberPlug.Visibility = Visibility.Visible;
            }
        }

        private void YearCard_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (YearCard.Text.Length > 0)
            {
                YearCardPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                YearCardPlug.Visibility = Visibility.Visible;
            }
        }

        private void MonthCard_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (MonthCard.Text.Length > 0)
            {
                MonthCardPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                MonthCardPlug.Visibility = Visibility.Visible;
            }
        }

        private void CVVCard_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CVVCard.Text.Length > 0)
            {
                CVVCardPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                CVVCardPlug.Visibility = Visibility.Visible;
            }
        }

        private void NameCard_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NameCard.Text.Length > 0)
            {
                NameCardPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                NameCardPlug.Visibility = Visibility.Visible;
            }
        }
    }
}
