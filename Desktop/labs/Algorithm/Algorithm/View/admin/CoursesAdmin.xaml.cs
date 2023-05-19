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
    public partial class CoursesAdmin : Page
    {
        AddCourse formAdd;
        DataManageCoursesAdmin context = new DataManageCoursesAdmin();
        public CoursesAdmin()
        {
            InitializeComponent();
            this.DataContext = context;
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            context.ClickCourse.Execute(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            formAdd = new AddCourse(context);
            formAdd.Show();
        }
    }
}
