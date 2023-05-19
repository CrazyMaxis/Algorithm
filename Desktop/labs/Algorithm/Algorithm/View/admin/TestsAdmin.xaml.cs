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
    public partial class TestsAdmin : Page
    {
        AddTest formAdd;
        DataManageTestsAdmin context = new DataManageTestsAdmin();
        public TestsAdmin()
        {
            InitializeComponent();
            this.DataContext = context;
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            context.ClickTest.Execute(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            formAdd = new AddTest(context);
            formAdd.Show();
        }
    }
}
