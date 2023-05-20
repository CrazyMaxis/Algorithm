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
using Algorithm.ViewModel.admin;

namespace Algorithm.View.admin
{
    public partial class UsersAndTestsAdmin : Page
    {
        DataManageUserTestsAdmin context = new DataManageUserTestsAdmin();
        public UsersAndTestsAdmin()
        {
            InitializeComponent();
            this.DataContext = context;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            context.ClickUserTest.Execute(this);
        }
    }
}
