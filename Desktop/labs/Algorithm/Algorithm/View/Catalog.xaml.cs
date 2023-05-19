using Algorithm.ViewModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Algorithm.Model;
using System.IO;
using Path = System.IO.Path;

namespace Algorithm.View
{
    public partial class Catalog : Page
    {
        DataManageCatalog context = new DataManageCatalog();
        public Catalog()
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
    }
}
