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

    public partial class FormLoginRegister : Window
    {
        Login login;
        Register register = new Register();

        public FormLoginRegister()
        {
            InitializeComponent();
            login = new Login(this);
            FrameLoginRegister.Navigate(login);
        }

        private void LoginIn_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (LoginIn.Text == "ЗАРЕГИСТРИРОВАТЬСЯ")
            {
                FrameLoginRegister.Navigate(register);
                LoginIn.Text = "ВОЙТИ";
                LoginIn.Margin = new Thickness(0, 530, 0, 0);
            }
            else
            {
                FrameLoginRegister.Navigate(login);
                LoginIn.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
                LoginIn.Margin = new Thickness(0, 330, 0, 0);
            }
        }
    }
}
