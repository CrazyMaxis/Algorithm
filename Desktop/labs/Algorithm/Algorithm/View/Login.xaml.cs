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
using Algorithm.Model;
using Algorithm.ViewModel;

namespace Algorithm.View
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public FormLoginRegister mainW;
        public Login(FormLoginRegister mw)
        {
            InitializeComponent();
            mainW = mw;
            this.DataContext = new DataManageVM();
        }

        

        private void LoginForLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LoginForLogin.Text.Length > 0)
            {
                LoginForLoginPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                LoginForLoginPlug.Visibility = Visibility.Visible;
            }
        }

        private void PasswordForLogin_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordForLogin.Password.Length > 0)
            {
                PasswordForLoginPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                PasswordForLoginPlug.Visibility = Visibility.Visible;
            }
        }
    }
}
