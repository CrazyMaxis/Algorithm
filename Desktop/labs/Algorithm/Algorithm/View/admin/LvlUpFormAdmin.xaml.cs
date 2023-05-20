using Algorithm.ViewModel.admin;
using Algorithm.Model;
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
    public partial class LvlUpFormAdmin : Window
    {
        public LvlUpFormAdmin(DataManageUserTestsAdmin context, User_Test Element)
        {
            InitializeComponent();
            this.DataContext = context;
        }
    }
}
