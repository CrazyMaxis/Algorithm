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
    public partial class CatalogAdmin : Page
    {
        DataManageCatalogAdmin context = new DataManageCatalogAdmin();
        AddAlgorithm formAdd;
        public CatalogAdmin()
        {
            InitializeComponent();
            this.DataContext = context;
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            context.ClickAlgorithmLevel0.Execute(this);
        }

        private void ListViewItem_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            context.ClickAlgorithmLevel1.Execute(this);
        }

        private void ListViewItem_MouseDoubleClick_2(object sender, MouseButtonEventArgs e)
        {
            context.ClickAlgorithmLevel2.Execute(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            formAdd = new AddAlgorithm(context);
            formAdd.Show();
        }
    }
}
