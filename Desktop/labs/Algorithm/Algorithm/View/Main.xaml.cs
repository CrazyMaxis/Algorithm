using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Algorithm.Model;

namespace Algorithm.View
{
    public partial class Main : Window
    {
        Home home;
        Catalog catalog = new Catalog();
        Profile profile = new Profile();
        Courses courses = new Courses();
        public Main()
        {
            InitializeComponent();
                        home = new Home(this);
            MainFrame.Navigate(home);
        }

        private void Profile_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ProfileButtons.Visibility == Visibility.Hidden) 
            {
                ProfileButtons.Visibility = Visibility.Visible;
            }
            else
            {
                ProfileButtons.Visibility = Visibility.Hidden;
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Process.Start("https://github.com/CrazyMaxis");
        }

        private void Catalog_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(catalog);
        }

        private void Home_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(home);
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            FormLoginRegister form = new FormLoginRegister();
            form.Show();
            this.Close();
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(profile);
        }

        private void Courses_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(courses);
        }
    }
}
