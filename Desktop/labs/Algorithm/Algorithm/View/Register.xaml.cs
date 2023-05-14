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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Algorithm.Model;
using Algorithm.ViewModel;

namespace Algorithm.View
{
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
            this.DataContext = new DataManageVM();
        }

        private void LoginForRegister_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LoginForRegister.Text.Length > 0)
            {
                LoginForRegisterPlug.Visibility = Visibility.Hidden;
                if (!Regex.IsMatch((sender as TextBox).Text, "^[a-zA-Z]{5,}\\d*$"))
                {
                    MessageBox.Show("ОШИБКА");
                }
            }
            else
            {
                LoginForRegisterPlug.Visibility = Visibility.Visible;
            }
        }

        private void EmailForRegister_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (EmailForRegister.Text.Length > 0)
            {
                EmailForRegisterPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                EmailForRegisterPlug.Visibility = Visibility.Visible;
            }
        }

        private void PasswordForRegister_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordForRegister.Password.Length > 0)
            {
                PasswordForRegisterPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                PasswordForRegisterPlug.Visibility = Visibility.Visible;
            }
        }
    }

}
